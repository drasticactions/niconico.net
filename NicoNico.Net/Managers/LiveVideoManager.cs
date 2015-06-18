using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NicoNico.Net.Entities.LiveVideo;
using NicoNico.Net.Entities.Message;
using NicoNico.Net.Interfaces;
using NicoNico.Net.Tools;

namespace NicoNico.Net.Managers
{
    public class LiveVideoManager : ILiveVideoManager
    {
        private readonly IWebManager _webManager;

        public LiveVideoManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public LiveVideoManager(CookieContainer container = null, string sessionKey = null)
        : this(new WebManager(container, sessionKey))
        {
        }

        public async Task<NicoliveVideoResponse> GetOnAirListAsync(int @from = 0, int length = 50, string order = "a", string provider = "community",
            string sort = "start_time")
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.OnAirList, from, length, order, provider, sort)));
            try
            {
                var live = JsonConvert.DeserializeObject<LiveVideo>(result.ResultXml);
                return live.NicoliveVideoResponse;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get live videos: " + result.ResultXml, ex);
            }
        }

        public async Task<NicoliveVideoResponse> GetComingSoonListAsync(int @from = 0, int length = 50, string provider = "community")
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.ComingSoon, from, length, provider)));
            try
            {
                var live = JsonConvert.DeserializeObject<LiveVideo>(result.ResultXml);
                return live.NicoliveVideoResponse;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get live videos: " + result.ResultXml, ex);
            }
        }
    }
}

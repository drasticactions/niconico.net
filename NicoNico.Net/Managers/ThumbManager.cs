using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.Video;
using NicoNico.Net.Interfaces;
using NicoNico.Net.Tools;

namespace NicoNico.Net.Managers
{
    public class ThumbManager : IThumbManager
    {
        private readonly IWebManager _webManager;

        public ThumbManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public ThumbManager(CookieContainer container = null, string sessionKey = null)
        : this(new WebManager(container, sessionKey))
        {
        }

        public async Task<Thumb> GetThumbInfoAsync(string videoId)
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.ThumbInfo, videoId)));
            var entity = result.ResultXml.ParseXml<ThumbnailEntity>();
            return entity.Thumbnail;
        }
    }
}

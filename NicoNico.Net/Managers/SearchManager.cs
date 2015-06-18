using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NicoNico.Net.Entities.LiveVideo;
using NicoNico.Net.Entities.Search;
using NicoNico.Net.Interfaces;
using NicoNico.Net.Tools;

namespace NicoNico.Net.Managers
{
    public class SearchManager : ISearchManager
    {
        private readonly IWebManager _webManager;

        public SearchManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public SearchManager(CookieContainer container = null, string sessionKey = null)
        : this(new WebManager(container, sessionKey))
        {
        }

        public async Task<Suggestion> GetSuggestions(string suggestion)
        {
            var result = await _webManager.GetData(new Uri(EndPoints.SearchSuggestion + suggestion));
            try
            {
                return JsonConvert.DeserializeObject<Suggestion>(result.ResultXml);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get suggestions" + result.ResultXml, ex);
            }
        }
    }
}

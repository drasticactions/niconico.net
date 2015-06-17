using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.Video;
using NicoNico.Net.Entities.Web;
using NicoNico.Net.Interfaces;
using NicoNico.Net.Tools;

namespace NicoNico.Net.Managers
{
    public class VideoManager : IVideoManager
    {
        private readonly IWebManager _webManager;

        public VideoManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public VideoManager(CookieContainer container = null, string sessionKey = null)
        : this(new WebManager(container, sessionKey))
        {
        }

        public async Task<Videos> GetVideoRankingsAsync(int @from, string genre = "all", int limit = 20, string span = "hourly", string type = "fav")
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.VideoRankings, from, genre, limit, span, type)));
            return result.ResultXml.ParseXml<Videos>();
        }

        public async Task<Videos> GetDefListAsync(int @from, int limit = 1)
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.DefVideoList, from, limit)));
            return result.ResultXml.ParseXml<Videos>();
        }

        public async Task<Videos> GetVideoSherlockAsync(string cmd = "recommend", int limit = 20)
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.VideoSherlock, cmd, limit)));
            return result.ResultXml.ParseXml<Videos>();
        }

        public async Task<VideoInfo> GetVideoInfoAsync(string videoId)
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.VideoInfo, videoId)));
            return result.ResultXml.ParseXml<VideoInfo>();
        }

        public async Task<Videos> GetVideoRelationAsync(string videoId, int @from = 0, int limit = 100, string order = "d", string sort = "v")
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.VideoRelation, from, limit, order, sort, videoId)));
            return result.ResultXml.ParseXml<Videos>();
        }

        public async Task<Videos> GetVideoInfoAsync(string[] videoIsArray)
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.VideoArray, string.Join(",", videoIsArray))));
            var xmlUserObject = result.ResultXml.ParseXml<Videos>();
            return xmlUserObject;
        }

        public async Task<VideoPlayback> GetVideoPlaybackInfoAsync(string videoId)
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.VideoPlay, videoId)));
            return result.ResultXml.ParseXml<VideoPlayback>();
        }
    }
}

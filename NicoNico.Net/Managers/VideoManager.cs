using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NicoNico.Net.Entities.Message;
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

        public async Task<VideoFlv> GetVideoFlvAsync(string videoId, string device = "metro", int eco = 5)
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.VideoFlv, device, eco, videoId)));
            var querystring = HttpUtility.ParseQueryString(result.ResultXml);
            var videoFlv = new VideoFlv();
            foreach (var item in querystring)
            {
                switch (item.Key)
                {
                    case "thread_id":
                        videoFlv.Id = Convert.ToUInt32(item.Value);
                        break;
                    case "l":
                        videoFlv.L = Convert.ToInt32(item.Value);
                        break;
                    case "url":
                        videoFlv.Url = item.Value;
                        break;
                    case "ms":
                        videoFlv.Ms = item.Value;
                        videoFlv.ApiChannel = ApiChannelParser(item.Value);
                        break;
                    case "ms_sub":
                        videoFlv.MsSub = item.Value;
                        break;
                    case "is_premium":
                        videoFlv.IsPremium = Convert.ToByte(item.Value);
                        break;
                    case "nickname":
                        videoFlv.Nickname = item.Value;
                        break;
                    case "time":
                        videoFlv.Time = Convert.ToInt64(item.Value);
                        break;
                    case "done":
                        videoFlv.Done = Boolean.Parse(item.Value);
                        break;
                    case "ng_rv":
                        videoFlv.NgRv = Convert.ToByte(item.Value);
                        break;
                    case "hms":
                        videoFlv.Hms = item.Value;
                        break;
                    case "hmsp":
                        videoFlv.Hmsp = Convert.ToInt32(item.Value);
                        break;
                    case "hmstk":
                        videoFlv.Hmstk = item.Value;
                        break;
                }
            }
            return videoFlv;
        }

        public async Task<List<MessageEntity>> GetVideoMessageEntityAsync(string threadId, int apiChannel, int resFrom = -100)
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.Message, threadId, resFrom, apiChannel)));
            try
            {
                return JsonConvert.DeserializeObject<List<MessageEntity>>(result.ResultXml);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to parse messages, check the ApiChannel");
            }
        }

        private int ApiChannelParser(string url)
        {
            var re1 = ".*?"; // Non-greedy match on filler
            var re2 = "(\\d+)";  // Integer Number 1

            var r = new Regex(re1 + re2, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            var m = r.Match(url);
            if (m.Success)
            {
                string int1 = m.Groups[1].ToString();
                return Convert.ToInt32(int1);
            }

            return 0;
        }
    }
}

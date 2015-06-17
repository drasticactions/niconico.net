using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.Message;
using NicoNico.Net.Entities.Video;

namespace NicoNico.Net.Interfaces
{
    public interface IVideoManager
    {
        // TODO: Change "Genre", "Span", and "Type" to use enums
        Task<Videos> GetVideoRankingsAsync(int from, 
            string genre = "all", int limit = 20, string span = "hourly",
            string type = "fav");

        Task<Videos> GetDefListAsync(int from, int limit = 1);

        Task<Videos> GetVideoSherlockAsync(string cmd = "recommend", int limit = 20);

        Task<VideoInfo> GetVideoInfoAsync(string videoId);

        Task<Videos> GetVideoRelationAsync(string videoId, 
            int from = 0, int limit = 100, string order = "d",
            string sort = "v");

        Task<Videos> GetVideoInfoAsync(string[] videoIsArray);

        Task<VideoPlayback> GetVideoPlaybackInfoAsync(string videoId);

        Task<VideoFlv> GetVideoFlvAsync(string videoId, string device = "metro", int eco = 5);

        Task<List<MessageEntity>> GetVideoMessageEntityAsync(string threadId, int apiChannel, int resFrom = -100);
    }
}

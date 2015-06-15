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
            var xmlUserObject = result.ResultXml.ParseXml<nicovideo_video_response>();
            var videos = new Videos()
            {
                Count = xmlUserObject.count,
                VideoInfoList = new List<VideoInfo>()
            };
            foreach (var item in xmlUserObject.video_info)
            {
                videos.VideoInfoList.Add(new VideoInfo()
                {
                    Video = new Video()
                    {
                        Deleted = item.video.deleted,
                        FirstRetrieve = item.video.first_retrieve,
                        Height = item.video.height,
                        Id = item.video.id,
                        LargeThumbnail = item.video.options.large_thumbnail,
                        LengthInSeconds = item.video.length_in_seconds,
                        Mobile = item.video.options.mobile,
                        MyListCounter = item.video.mylist_counter,
                        OptionFlagCommunity = item.video.option_flag_community,
                        OptionFlagMiddleThumbnail = item.video.option_flag_middle_thumbnail,
                        OptionFlagNicowari = item.video.option_flag_nicowari,
                        ViewCounter = item.video.view_counter,
                        VitaPlayable = item.video.vita_playable,
                        PpvVideo = item.video.ppv_video,
                        ProviderType = item.video.provider_type,
                        Title = item.video.title,
                        UploadTime = item.video.upload_time,
                        ThumbnailUrl = item.video.thumbnail_url,
                        Width = item.video.width,
                        Sun = item.video.options.sun
                    },
                    Thread = new Thread()
                    {
                        Id = item.thread.id,
                        NumRes = item.thread.num_res,
                        Summary = item.thread.summary
                    }
                });
            }
            return videos;
        }

        public async Task<Videos> GetDefListAsync(int @from, int limit = 1)
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.DefVideoList, from, limit)));
            var xmlUserObject = result.ResultXml.ParseXml<nicovideo_video_response>();
            var videos = new Videos()
            {
                Count = xmlUserObject.count,
                VideoInfoList = new List<VideoInfo>(),
                TotalCount = xmlUserObject.total_count
            };
            foreach (var item in xmlUserObject.video_info)
            {
                videos.VideoInfoList.Add(new VideoInfo()
                {
                    Video = new Video()
                    {
                        Deleted = item.video.deleted,
                        FirstRetrieve = item.video.first_retrieve,
                        Height = item.video.height,
                        Id = item.video.id,
                        LargeThumbnail = item.video.options.large_thumbnail,
                        LengthInSeconds = item.video.length_in_seconds,
                        Mobile = item.video.options.mobile,
                        MyListCounter = item.video.mylist_counter,
                        OptionFlagCommunity = item.video.option_flag_community,
                        OptionFlagMiddleThumbnail = item.video.option_flag_middle_thumbnail,
                        OptionFlagNicowari = item.video.option_flag_nicowari,
                        ViewCounter = item.video.view_counter,
                        VitaPlayable = item.video.vita_playable,
                        PpvVideo = item.video.ppv_video,
                        ProviderType = item.video.provider_type,
                        Title = item.video.title,
                        UploadTime = item.video.upload_time,
                        ThumbnailUrl = item.video.thumbnail_url,
                        Width = item.video.width,
                        Sun = item.video.options.sun
                    },
                    Thread = new Thread()
                    {
                        Id = item.thread.id,
                        NumRes = item.thread.num_res,
                        Summary = item.thread.summary
                    },
                    MyList = new MyList()
                    {
                        CreateTime = item.mylist.create_time,
                        UpdateTime = item.mylist.update_time
                    }
                });
            }
            return videos;
        }

        public async Task<Videos> GetVideoSherlockAsync(string cmd = "recommend", int limit = 20)
        {
            var result = await _webManager.GetData(new Uri(string.Format(EndPoints.VideoSherlock, cmd, limit)));
            var xmlUserObject = result.ResultXml.ParseXml<nicovideo_video_response>();
            var videos = new Videos()
            {
                Count = xmlUserObject.count,
                VideoInfoList = new List<VideoInfo>(),
                SherlockTags = new List<string>(),
                SherlockVideos = new List<SherlockVideo>()
            };
            foreach (var item in xmlUserObject.video_info)
            {
                videos.VideoInfoList.Add(new VideoInfo()
                {
                    Video = new Video()
                    {
                        Deleted = item.video.deleted,
                        FirstRetrieve = item.video.first_retrieve,
                        Height = item.video.height,
                        Id = item.video.id,
                        LargeThumbnail = item.video.options.large_thumbnail,
                        LengthInSeconds = item.video.length_in_seconds,
                        Mobile = item.video.options.mobile,
                        MyListCounter = item.video.mylist_counter,
                        OptionFlagCommunity = item.video.option_flag_community,
                        OptionFlagMiddleThumbnail = item.video.option_flag_middle_thumbnail,
                        OptionFlagNicowari = item.video.option_flag_nicowari,
                        ViewCounter = item.video.view_counter,
                        VitaPlayable = item.video.vita_playable,
                        PpvVideo = item.video.ppv_video,
                        ProviderType = item.video.provider_type,
                        Title = item.video.title,
                        UploadTime = item.video.upload_time,
                        ThumbnailUrl = item.video.thumbnail_url,
                        Width = item.video.width,
                        Sun = item.video.options.sun
                    },
                    Thread = new Thread()
                    {
                        Id = item.thread.id,
                        NumRes = item.thread.num_res,
                        Summary = item.thread.summary
                    }
                });
            }
            foreach (var item in xmlUserObject.sherlock_tag)
            {
                videos.SherlockTags.Add(item);
            }

            foreach (var item in xmlUserObject.sherlock_video)
            {
                videos.SherlockVideos.Add(new SherlockVideo()
                {
                    Id = item.id,
                    Tag = item.tag
                });
            }
            return videos;
        }
    }
}

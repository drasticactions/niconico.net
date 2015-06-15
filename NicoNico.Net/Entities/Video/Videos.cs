using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicoNico.Net.Entities.Video
{
    public class Videos
    {
        public int Count { get; set; }

        public int TotalCount { get; set; }

        public List<VideoInfo> VideoInfoList { get; set; }

        public List<string> SherlockTags { get; set; }

        public List<SherlockVideo> SherlockVideos { get; set; }
    }

    public class SherlockVideo
    {
        public string Id { get; set; }

        public string Tag { get; set; }
    }

    public class VideoInfo
    {
        public Video Video { get; set; }

        public Thread Thread { get; set; }

        public MyList MyList { get; set; }
    }

    public class Video
    {
        public string Id { get; set; }

        public string Tag { get; set; }

        public byte Deleted { get; set; }

        public string Title { get; set; }

        public int LengthInSeconds { get; set; }

        public string ThumbnailUrl { get; set; }

        public DateTime UploadTime { get; set; }

        public DateTime FirstRetrieve { get; set; }

        public uint ViewCounter { get; set; }

        public int MyListCounter { get; set; }

        public int OptionFlagCommunity { get; set; }

        public byte OptionFlagNicowari { get; set; }

        public byte OptionFlagMiddleThumbnail { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public string VitaPlayable { get; set; }

        public byte PpvVideo { get; set; }

        public string ProviderType { get; set; }

        public byte Mobile { get; set; }

        public byte Sun { get; set; }

        public byte LargeThumbnail { get; set; }
    }

    public class Thread
    {
        public uint Id { get; set; }

        public int NumRes { get; set; }

        public string Summary { get; set; }
    }

    public class MyList
    {
        public string Description { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime CreateTime { get; set; }
    }


}

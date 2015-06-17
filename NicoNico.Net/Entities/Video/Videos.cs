using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NicoNico.Net.Entities.Video
{
    [XmlRoot("nicovideo_video_response")]
    public class Videos
    {
        [XmlElement("count")]
        public int Count { get; set; }

        [XmlElement("total_count")]
        public int TotalCount { get; set; }

        [XmlElement("video_info")]
        public List<VideoInfo> VideoInfoList { get; set; }

        [XmlElement("sherlock_tag")]
        public List<SherlockTag> SherlockTags { get; set; }

        [XmlElement("sherlock_video")]
        public List<SherlockVideo> SherlockVideos { get; set; }

        [XmlElement("tags")]
        public List<TagInfo> Tags { get; set; }
    }

    public class SherlockTag
    {
        [XmlElement("tag")]
        public string Tag { get; set; }
    }

    public class SherlockVideo
    {
        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("tag")]
        public string Tag { get; set; }
    }

    [XmlType("nicovideo_video_response")]
    public class VideoInfo
    {
        [XmlElement("video")]
        public Video Video { get; set; }

        [XmlElement("thread")]
        public Thread Thread { get; set; }

        [XmlElement("mylist")]
        public MyList MyList { get; set; }
    }

    [XmlType("tag_info")]
    public class TagInfo
    {
        [XmlElement("tag")]
        public string Tag { get; set; }

        [XmlElement("area")]
        public string Area { get; set; }
    }

    public class Video
    {
        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("deleted")]
        public byte Deleted { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("length_in_seconds")]
        public int LengthInSeconds { get; set; }

        [XmlElement("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [XmlElement("upload_time")]
        public DateTime UploadTime { get; set; }

        [XmlElement("first_retrieve")]
        public DateTime FirstRetrieve { get; set; }

        [XmlElement("view_counter")]
        public uint ViewCounter { get; set; }

        [XmlElement("mylist_counter")]
        public int MyListCounter { get; set; }

        [XmlElement("option_flag_community")]
        public int OptionFlagCommunity { get; set; }

        [XmlElement("option_flag_nicowari")]
        public byte OptionFlagNicowari { get; set; }

        [XmlElement("option_flag_middle_thumbnail")]
        public byte OptionFlagMiddleThumbnail { get; set; }

        [XmlElement("width")]
        public int Width { get; set; }

        [XmlElement("height")]
        public int Height { get; set; }

        [XmlElement("vita_playable")]
        public string VitaPlayable { get; set; }

        [XmlElement("ppv_video")]
        public byte PpvVideo { get; set; }

        [XmlElement("provider_type")]
        public string ProviderType { get; set; }

        public byte Mobile { get; set; }

        public byte Sun { get; set; }

        public byte LargeThumbnail { get; set; }
    }

    public class Thread
    {
        [XmlElement("id")]
        public uint Id { get; set; }

        [XmlElement("num_res")]
        public int NumRes { get; set; }

        [XmlElement("summary")]
        public string Summary { get; set; }
    }

    public class MyList
    {
        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("update_time")]
        public DateTime UpdateTime { get; set; }

        [XmlElement("create_time")]
        public DateTime CreateTime { get; set; }
    }


}

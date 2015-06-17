using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NicoNico.Net.Entities.Video
{
    [XmlRoot("nicovideo_thumb_response")]
    public class ThumbnailEntity
    {
        [XmlElement("thumb")]
        public Thumb Thumbnail { get; set; }
    }

    public class Thumb
    {
        [XmlElement("video_id")]
        public string VideoId { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlElement("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
        [XmlElement("first_retrieve")]
        public DateTime FirstRetrieve { get; set; }
        [XmlElement("length")]
        public string Length { get; set; }
        [XmlElement("movie_type")]
        public string MovieType { get; set; }
        [XmlElement("size_high")]
        public int SizeHigh { get; set; }
        [XmlElement("size_low")]
        public int SizeLow { get; set; }
        [XmlElement("view_counter")]
        public int ViewCounter { get; set; }
        [XmlElement("comment_num")]
        public int CommentNum { get; set; }
        [XmlElement("mylist_counter")]
        public int MyListCounter { get; set; }
        [XmlElement("last_res_body")]
        public string LastResBody { get; set; }
        [XmlElement("watch_url")]
        public string WatchUrl { get; set; }
        [XmlElement("thumb_type")]
        public string ThumbType { get; set; }
        [XmlElement("embeddable")]
        public byte Embeddable { get; set; }
        [XmlElement("no_live_play")]
        public byte NoLivePlay { get; set; }
        [XmlElement("tags")]
        public List<TagString> Tags { get; set; }
        [XmlElement("user_id")]
        public uint UserId { get; set; }
        [XmlElement("user_nickname")]
        public string UserNickname { get; set; }
        [XmlElement("user_icon_url")]
        public string UserIconUrl { get; set; }
    }

    public class TagString
    {
        [XmlElement("tag")]
        public string Tag { get; set; }
    }
}

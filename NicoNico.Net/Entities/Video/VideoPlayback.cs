using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NicoNico.Net.Entities.Video
{
    [XmlRoot("nicovideo_video_response")]
    public class VideoPlayback
    {
        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("enable_low")]
        public byte EnableLow { get; set; }

        [XmlElement("enable_mid")]
        public byte EnableMid { get; set; }

        [XmlElement("enable_org")]
        public byte EnableOrg { get; set; }

        [XmlElement("commentable")]
        public byte Commentable { get; set; }

        [XmlElement("comment_type")]
        public byte CommentType { get; set; }

        [XmlElement("video_priority")]
        public byte VideoPriority { get; set; }

        [XmlElement("allow_range")]
        public byte AllowRange { get; set; }

        [XmlElement("formatinfo")]
        public FormatInfo FormatInfo { get; set; }

        [XmlElement("watch")]
        public Watch Watch { get; set; }
    }

    public class FormatInfo
    {
        [XmlElement("width")]
        public int Width { get; set; }

        [XmlElement("height")]
        public int Height { get; set; }

        [XmlElement("h264_profile")]
        public int H264Profile { get; set; }

        [XmlElement("h264_level")]
        public int H264Level { get; set; }

        [XmlElement("framerate")]
        public int Framerate { get; set; }
    }

    public class Watch
    {
        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("mode")]
        public string Mode { get; set; }

        [XmlElement("device")]
        public string Device { get; set; }

        [XmlElement("playlist_token")]
        public string PlaylistToken { get; set; }
    }
}

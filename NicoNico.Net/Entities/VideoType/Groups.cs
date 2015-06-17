using System.Collections.Generic;
using System.Xml.Serialization;

namespace NicoNico.Net.Entities.VideoType
{
    [XmlRoot("nicovideo_genre_response")]
    public class GroupEntity
    {
        [XmlElement("groups")]
        public List<Groups> Groups { get; set; }
    }

    public class Groups
    {
        [XmlElement("group")]
        public string Group { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("key")]
        public List<string> Keys { get; set; } 
    }
}

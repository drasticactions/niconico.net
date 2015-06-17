using System.Collections.Generic;
using System.Xml.Serialization;

namespace NicoNico.Net.Entities.VideoType
{
    [XmlRoot("nicovideo_genre_response")]
    public class GenreEntity
    {
        [XmlElement("genre")]
        public List<Genre> Genres { get; set; } 
    }

    public class Genre
    {
        [XmlElement("key")]
        public string Key { get; set; }

        [XmlElement("tag")]
        public string Tag { get; set; }
    }
}

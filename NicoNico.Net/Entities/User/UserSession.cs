using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NicoNico.Net.Entities.User
{
    [XmlRoot("nicovideo_user_response")]
    public class UserSession
    {
        [XmlElement("id")]
        public uint Id { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("session")]
        public string Session { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NicoNico.Net.Entities.User
{
    [XmlRoot("nicovideo_user_response")]
    public class UserLoginSession
    {
        [XmlElement("user_id")]
        public uint UserId { get; set; }

        [XmlElement("session_key")]
        public string SessionKey { get; set; }

        [XmlElement("expire")]
        public string Expire { get; set; }
    }
}

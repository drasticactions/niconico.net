using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NicoNico.Net.Entities.User
{
    [XmlRoot("nicovideo_user_response")]
    public class UserEntity
    {
        [XmlElement("user")]
        public User User { get; set; }

        [XmlElement("vita_option")]
        public VitaOption VitaOption { get; set; }
    }

    public class User
    {
        [XmlElement("id")]
        public uint Id { get; set; }

        [XmlElement("mobile_mail")]
        public byte MobileMail { get; set; }

        [XmlElement("nickname")]
        public string Nickname { get; set; }
        [XmlElement("prefecture")]
        public string Prefecture { get; set; }

        [XmlElement("birthday")]
        public DateTime Birthday { get; set; }

        [XmlElement("sex")]
        public string Sex { get; set; }

        [XmlElement("country")]
        public string Country { get; set; }

        [XmlElement("language")]
        public string Language { get; set; }

        [XmlElement("create_time")]
        public DateTime CreateTime { get; set; }

        [XmlElement("update_time")]
        public DateTime UpdateTime { get; set; }

        [XmlElement("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        public Premium Premium { get; set; }
    }

    public class VitaOption
    {
        [XmlElement("user_secret")]
        public byte UserSecret { get; set; }
        [XmlElement("simple_register_profile")]
        public byte SimpleRegisterProfile { get; set; }
    }

    [XmlRoot("nicovideo_user_response")]
    public class Premium
    {
        [XmlElement("premium")]
        public byte IsPremium { get; set; }
        [XmlElement("expire_time")]
        public uint ExpireTime { get; set; }
        [XmlElement("purchasable")]
        public byte Purchaseable { get; set; }
    }
}

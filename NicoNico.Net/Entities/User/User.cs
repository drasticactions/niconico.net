using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicoNico.Net.Entities.User
{
    public class User
    {
        public uint Id { get; set; }

        public byte MobileMail { get; set; }

        public string Nickname { get; set; }

        public string Prefecture { get; set; }

        public DateTime Birthday { get; set; }

        public string Sex { get; set; }

        public string Country { get; set; }

        public string Language { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public string ThumbnailUrl { get; set; }

        public VitaOption VitaOption { get; set; }

        public Premium Premium { get; set; }
    }

    public class VitaOption
    {
        public byte UserSecret { get; set; }

        public byte SimpleRegisterProfile { get; set; }
    }

    public class Premium
    {
        public byte IsPremium { get; set; }

        public uint ExpireTime { get; set; }

        public byte Purchaseable { get; set; }
    }
}

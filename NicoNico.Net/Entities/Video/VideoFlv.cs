using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicoNico.Net.Entities.Video
{
    public class VideoFlv
    {
        public uint Id { get; set; }

        public int L { get; set; }

        public string Url { get; set; }

        public string Ms { get; set; }

        public int ApiChannel { get; set; }

        public string MsSub { get; set; }

        public byte IsPremium { get; set; }

        public string Nickname { get; set; }

        public long Time { get; set; }

        public bool Done { get; set; }

        public byte NgRv { get; set; }

        public string Hms { get; set; }

        public int Hmsp { get; set; }

        public int Hmst { get; set; }

        public string Hmstk { get; set; }
    }
}

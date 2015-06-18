using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NicoNico.Net.Entities.LiveVideo
{
    public class LiveVideo
    {
        [JsonProperty("nicolive_video_response")]
        public NicoliveVideoResponse NicoliveVideoResponse { get; set; }
    }
}

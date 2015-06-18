using Newtonsoft.Json;

namespace NicoNico.Net.Entities.LiveVideo
{

    public class VideoInfo
    {

        [JsonProperty("video")]
        public Video Video { get; set; }

        [JsonProperty("community")]
        public Community Community { get; set; }
    }

}

using Newtonsoft.Json;

namespace NicoNico.Net.Entities.LiveVideo
{

    public class Community
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        [JsonProperty("global_id")]
        public string GlobalId { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("thumbnail_small")]
        public string ThumbnailSmall { get; set; }
    }

}

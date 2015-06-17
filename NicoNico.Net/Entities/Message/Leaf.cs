using Newtonsoft.Json;

namespace NicoNico.Net.Entities.Message
{

    public class Leaf
    {

        [JsonProperty("thread")]
        public int Thread { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("leaf")]
        public int? LeafId { get; set; }
    }

}

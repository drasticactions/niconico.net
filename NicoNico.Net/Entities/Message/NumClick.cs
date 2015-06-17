using Newtonsoft.Json;

namespace NicoNico.Net.Entities.Message
{

    public class NumClick
    {

        [JsonProperty("thread")]
        public int Thread { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

}

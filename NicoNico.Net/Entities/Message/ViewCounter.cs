
using Newtonsoft.Json;

namespace NicoNico.Net.Entities.Message
{

    public class ViewCounter
    {

        [JsonProperty("video")]
        public int Video { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mylist")]
        public int Mylist { get; set; }
    }

}

using Newtonsoft.Json;

namespace NicoNico.Net.Entities.Message
{

    public class Chat
    {

        [JsonProperty("thread")]
        public int Thread { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("vpos")]
        public int Vpos { get; set; }

        [JsonProperty("date")]
        public int Date { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("anonymity")]
        public int Anonymity { get; set; }

        [JsonProperty("leaf")]
        public int Leaf { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("premium")]
        public int? Premium { get; set; }
    }

}

using Newtonsoft.Json;

namespace NicoNico.Net.Entities.Message
{

    public class Thread
    {

        [JsonProperty("resultcode")]
        public int Resultcode { get; set; }

        [JsonProperty("thread")]
        public int ThreadId { get; set; }

        [JsonProperty("last_res")]
        public int LastRes { get; set; }

        [JsonProperty("ticket")]
        public string Ticket { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("server_time")]
        public int ServerTime { get; set; }

        [JsonProperty("click_revision")]
        public int ClickRevision { get; set; }

        [JsonProperty("num_clicks")]
        public int NumClicks { get; set; }
    }

}

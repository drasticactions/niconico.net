using Newtonsoft.Json;

namespace NicoNico.Net.Entities.VideoType
{

    public class Group
    {

        [JsonProperty("group")]
        public string GroupName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public object Key { get; set; }
    }

}

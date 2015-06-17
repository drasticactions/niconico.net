using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Newtonsoft.Json;

namespace NicoNico.Net.Entities.Message
{
    public class MessageEntity
    {
        [JsonProperty("thread")]
        public Thread Thread { get; set; }

        [JsonProperty("leaf")]
        public Leaf Leaf { get; set; }

        [JsonProperty("view_counter")]
        public ViewCounter ViewCounter { get; set; }

        [JsonProperty("chat")]
        public Chat Chat { get; set; }

        [JsonProperty("num_click")]
        public NumClick NumClick { get; set; }
    }
}

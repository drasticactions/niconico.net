using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NicoNico.Net.Entities.Search
{
    public class Suggestion
    {
        [JsonProperty("candidates")]
        public string[] Candidates { get; set; }
    }
}

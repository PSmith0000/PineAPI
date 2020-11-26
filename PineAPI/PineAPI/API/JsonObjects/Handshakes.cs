using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineAPI.API.JsonObjects
{
    public class Handshakes
    {
        [JsonProperty]
        public HandShake[] HandShakes { get; set; }
        public class HandShake
        {
            [JsonProperty]
            public int id { get; set; }
            [JsonProperty]
            public string message { get; set; }

            [JsonProperty]
            public int level { get; set; }

            [JsonProperty]
            public string time { get; set; }

            [JsonProperty]
            public bool read { get; set; }

            [JsonProperty]
            public bool displayed { get; set; }

            [JsonProperty]
            public string module_name { get; set; }
        }
    }
}

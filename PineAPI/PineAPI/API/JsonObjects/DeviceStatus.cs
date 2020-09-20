using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineAPI.API.JsonObjects
{
    public class DeviceStatus
    {
        [JsonProperty("versionString")]
        public string VersionString { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("uptime")]
        public int Uptime { get; set; }

        [JsonProperty("hostname")]
        public string HostName { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }
    }

}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineAPI.API.JsonObjects
{
    public class ServiceSetIDs
    {

        [JsonProperty]
        public string ssids { get; set; }
    }

    public class ServiceSetID
    {
        public ServiceSetID(string Ssid)
        {
            ssid = Ssid;
        }

        [JsonProperty]
        public string ssid { get; set; }
    }
}

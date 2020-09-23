using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PineAPI.API.JsonObjects
{
    public class PineAP
    {
        [JsonProperty]
        public string mode { get; set; }

        [JsonProperty]
        public Settings settings { get; set; }
    }

    public class Settings
    {
        [JsonProperty]
        public string ap_channel { get; set; }

        [JsonProperty]
        public bool auto_mac_filter { get; internal set; }

        [JsonProperty]
        public bool auto_ssid_filter { get; internal set; }

        [JsonProperty]
        public bool autostart { get; internal set; }

        [JsonProperty]
        public bool autostartPineAP { get; set; }

        [JsonProperty]
        public string beacon_interval { get; set; }

        [JsonProperty]
        public string beacon_response_interval { get; set; }

        [JsonProperty]
        public bool beacon_responses { get; set; }

        [JsonProperty]
        public bool broadcast_ssid_pool { get; set; }

        [JsonProperty]
        public bool capture_ssids { get; set; }

        [JsonProperty]
        public bool connect_notifications { get; set; }

        [JsonProperty]
        public bool disconnect_notifications { get; set; }

        [JsonProperty]
        public bool enablePineAP { get; set; }

        [JsonProperty]
        public string filters_db_path { get; internal set; }

        [JsonProperty]
        public string hostapd_db_path { get; internal set; }

        [JsonProperty]
        public bool karma { get; set; }

        [JsonProperty]
        public bool logging { get; set; }

        [JsonProperty]
        public string mac_filter { get; internal set; }

        [JsonProperty]
        public string pineap_interface { get; internal set; }

        [JsonProperty]
        public string pineap_mac { get; set; }

        [JsonProperty]
        public string recon_db_path { get; internal set; }

        [JsonProperty]
        public string ssid_db_path { get; internal set; }

        [JsonProperty]
        public string ssid_filter { get;  internal set; }

        [JsonProperty]
        public string target_mac { get; set; }
    }

    public class UpdatedSettings
    {
        [JsonProperty]
        public string mode = "advanced";

        [JsonProperty]
        public string ap_channel { get; set; }
    
        [JsonProperty]
        public bool autostartPineAP { get; set; }

        [JsonProperty]
        public string beacon_interval { get; set; }

        [JsonProperty]
        public string beacon_response_interval { get; set; }

        [JsonProperty]
        public bool beacon_responses { get; set; }

        [JsonProperty]
        public bool broadcast_ssid_pool { get; set; }

        [JsonProperty]
        public bool capture_ssids { get; set; }

        [JsonProperty]
        public bool connect_notifications { get; set; }

        [JsonProperty]
        public bool disconnect_notifications { get; set; }

        [JsonProperty]
        public bool enablePineAP { get; set; }

        [JsonProperty]
        public bool karma { get; set; }

        [JsonProperty]
        public bool logging { get; set; }

        [JsonProperty]
        public string pineap_mac { get; set; }

        [JsonProperty]
        public string target_mac { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static string CreateUpdate_JSON(Settings settings)
        {
            string updated = JsonConvert.SerializeObject(settings);
            return ((UpdatedSettings)JsonConvert.DeserializeObject(updated, typeof(UpdatedSettings))).ToJson();         
        }
    }
}

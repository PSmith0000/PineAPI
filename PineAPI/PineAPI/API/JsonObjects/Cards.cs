using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineAPI.API.JsonObjects
{
    public class Cards
    {
        [JsonProperty("systemStatus")]
        public SystemStatus SystemStatus { get; set; }

        [JsonProperty("diskUsage")]
        public DiskUsage DiskUsage { get; set; }

        [JsonProperty("clientsConnected")]
        public string ClientsConnected { get; set; }

        [JsonProperty("previousClients")]
        public string PreviousClients { get; set; }

        [JsonProperty("ssidsSeen")]
        public SsidsSeen SsidsSeen { get; set; }

        [JsonProperty("mostPopularTraffic")]
        public MostPopularTraffic MostPopularTraffic { get; set; }

        [JsonProperty("totalBandwidthUsed")]
        public long TotalBandwidthUsed { get; set; }

        [JsonProperty("reconScansRan")]
        public long ReconScansRan { get; set; }
    }

    public partial class DiskUsage
    {
        [JsonProperty("rootUsage")]
        public string RootUsage { get; set; }
    }

    public partial class MostPopularTraffic
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("second")]
        public string Second { get; set; }

        [JsonProperty("third")]
        public string Third { get; set; }
    }

    public partial class SsidsSeen
    {
        [JsonProperty("totalSSIDs")]
        public string TotalSsiDs { get; set; }

        [JsonProperty("currentSSIDs")]
        public string CurrentSsiDs { get; set; }
    }

    public partial class SystemStatus
    {
        [JsonProperty("cpuUsage")]
        public string CpuUsage { get; set; }

        [JsonProperty("memoryUsage")]
        public string MemoryUsage { get; set; }

        [JsonProperty("temperature")]
        public string Temperature { get; set; }
    }

}

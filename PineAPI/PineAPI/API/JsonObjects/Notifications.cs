using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineAPI.API.JsonObjects
{
    public class Notifications
    {
        public class Notification
        {
            public Notification(int Lvl, string Msg)
            {
                Level = Lvl;
                Message = Msg;
            }
            [JsonProperty("level")]
            internal int Level { get; set; }
            [JsonProperty("message")]
            internal string Message { get; set; }
        }

        public class NotificationEntry
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("level")]
            public long Level { get; set; }

            [JsonProperty("time")]
            public DateTimeOffset Time { get; set; }

            [JsonProperty("read")]
            public bool Read { get; set; }

            [JsonProperty("displayed")]
            public bool Displayed { get; set; }

            [JsonProperty("module_name")]
            public string ModuleName { get; set; }
        }
    }
}

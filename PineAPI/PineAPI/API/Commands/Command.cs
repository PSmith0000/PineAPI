using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using PineAPI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineAPI.API.Commands
{
    /// <summary>
    /// Command Object for our Pine Commands!
    /// </summary>
    class Command
    {
        public Command(string name, string method, string RequestURI, Type JsonT, string data = null)
        {
            Name = name;
            httpMethod = method;
            RequestUri = RequestURI;
            JsonType = JsonT;
            Data = data;
        }

        internal string Name { get; set; }
        internal string httpMethod { get; set; }
        internal string RequestUri { get; set; }
        internal Type JsonType { get; set; }

        internal string Data { get; set; }

        /// <summary>
        /// Executes our Command and returns defined.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        internal T Execute<T>(string JsonString = null, object[] _param = null)
        {
            var _data = Data == null ? JsonString : Data;
            var request = Network.MakeRequest(Config.GateWay, RequestUri, null, httpMethod, _data).Content.ReadAsStringAsync().Result;
            if(JsonType == typeof(JsonObjects.AuthToken))
            {
                return (T)Convert.ChangeType(JsonConvert.DeserializeObject(request, JsonType), JsonType);
            }
            else if(JsonType == typeof(JsonObjects.BooleanResult))
            {
                return (T)Convert.ChangeType(JsonConvert.DeserializeObject(request, JsonType), typeof(JsonObjects.BooleanResult));
            }
            else if (JsonType == typeof(JsonObjects.Notifications.Notification_Array_Item[]))
            {
                return (T)Convert.ChangeType(JsonConvert.DeserializeObject(request, JsonType), typeof(JsonObjects.Notifications.Notification_Array_Item[]));
            }
            return (T)Convert.ChangeType(false, typeof(bool));
        }
    }
}

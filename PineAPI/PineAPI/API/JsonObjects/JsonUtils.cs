using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineAPI.API.JsonObjects
{
    public class JsonUtils
    {
        public static string CreateJsonString(object JsonObject)
        {
            return (string)JsonConvert.SerializeObject(JsonObject);
        }
    }
}

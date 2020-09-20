using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace PineAPI.API.JsonObjects
{
    public class BooleanResult
    {
        [JsonProperty("success")]
        public string Success { get; set; }

        public bool ToBoolean()
        {
            return bool.Parse(Success);
        }
    }
}

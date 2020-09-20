using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace PineAPI.API.JsonObjects
{
    public class AuthToken
    {
        [JsonProperty("token")]
        public static string Token { get; set; }

        public override string ToString()
        {
            return Token;
        }
    }
}

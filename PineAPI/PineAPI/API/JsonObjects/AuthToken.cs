﻿using System;
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
        public string Token { get; set; }
    }
}

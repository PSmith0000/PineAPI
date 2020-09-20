using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
namespace PineAPI.Utils
{
    /// <summary>
    /// Handles all network communication
    /// </summary>
    class Network
    {
        internal static HttpClient httpClient = new HttpClient();

        /// <summary>
        /// Sends a http request this is not exposed in the API
        /// </summary>
        /// <param name="Gateway">PineApple Ip and port</param>
        /// <param name="RequestUri">Command EndPoint: Example("login")</param>
        /// <param name="Jsontype">Json Object Type</param>
        /// <param name="Method">Http Method</param>
        /// <param name="CONTENT">Request Body</param>
        /// <returns></returns>
        internal static HttpResponseMessage MakeRequest(string Gateway, string RequestUri, Type Jsontype, string Method = "GET", object CONTENT = null)
        {
            HttpRequestMessage msg = new HttpRequestMessage();
            msg.Method = new HttpMethod(Method);
            msg.RequestUri = new Uri($"http://{Gateway}/api/" + RequestUri);
            if (Config.Token != null) { msg.Headers.Add("Authorization", "Bearer " + Config.Token); }
            if (CONTENT != null)
            {
                msg.Content = new StringContent((string)CONTENT);
            }
            var r = httpClient.SendAsync(msg).Result;
            return r;
        }
    }
}

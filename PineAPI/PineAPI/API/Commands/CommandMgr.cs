using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PineAPI.API.JsonObjects;
namespace PineAPI.API.Commands
{
    class CommandMgr
    {

        internal static Dictionary<string, Command> Commands = new Dictionary<string, Command>() {
            {"LOGIN", new Command("Login", "POST", "login", typeof(JsonObjects.AuthToken), Config.LoginCombo)},
            {"SendNotification", new Command("SendNotification", "PUT", "notifications", typeof(JsonObjects.BooleanResult)) },
            {"Get_All_Notification", new Command("Get_All_Notification", "GET", "notifications", typeof(JsonObjects.Notifications.Notification_Array_Item[]))},
            {"DeleteAllNotifications", new Command("DeleteAllNotifications", "DELETE", "notifications", typeof(JsonObjects.BooleanResult)) },
            {"Read_All_Notifications", new Command("Read_All_Notifications", "PUT", "notifications/read", typeof(BooleanResult))}
        };

        /// <summary>
        /// Executes a API Command
        /// </summary>
        /// <typeparam name="T">JsonObject</typeparam>
        /// <param name="name">Name of command</param>
        /// <param name="cb">Callback function to handle return data</param>
        /// <param name="JsonString">JsonString: if required</param>
        /// <param name="_params">Optional Params: if required</param>
        /// <returns></returns>
        internal static bool ExecCommand<T>(string name, Func<object, bool> cb, string JsonString = null, object[] _params = null)
        {          
            var cmd = Commands.Where(x => x.Key == name).FirstOrDefault().Value;
            return cb(cmd.Execute<T>(JsonString, _params));
        }
    }
}

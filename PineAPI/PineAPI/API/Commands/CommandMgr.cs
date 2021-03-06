﻿using Newtonsoft.Json;
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
            {"Get_All_Notification", new Command("Get_All_Notification", "GET", "notifications", typeof(JsonObjects.Notifications.NotificationEntry[]))},
            {"DeleteAllNotifications", new Command("DeleteAllNotifications", "DELETE", "notifications", typeof(JsonObjects.BooleanResult)) },
            {"Read_All_Notifications", new Command("Read_All_Notifications", "PUT", "notifications/read", typeof(BooleanResult))},
            {"DeleteNotification", new Command("DeleteNotification", "DELETE", "notifications/{id}", typeof(BooleanResult))},
            {"ReadNotification", new Command("ReadNotification", "PUT", "notifications/{id}/read", typeof(BooleanResult)) },
            {"DispalyedNotification", new Command("DisplayedNotification", "PUT", "notifications/{id}/displayed", typeof(BooleanResult)) },

            {"Reboot", new Command("Reboot", "POST", "reboot", typeof(BooleanResult)) },
            {"Shutdown", new Command("Shutdown", "POST", "shutdown", typeof(BooleanResult)) },
            {"DeviceStatus", new Command("DeviceStatus", "GET", "status", typeof(DeviceStatus)) },
            {"GetDeviceType", new Command("GetDeviceType", "GET", "device", typeof(DeviceType)) },
            {"DownloadFile", new Command("DownloadFile", "POST", "download", typeof(BooleanResult)) }, //need doc update to complete
            {"GetStats", new Command("GetStats", "GET", "dashboard/cards", typeof(Cards)) },
            {"GetPineAP_Settings", new Command("GetPineAP_Settings", "GET", "pineap/settings", typeof(PineAP)) },
            {"UpdatePineAP_Settings", new Command("UpdatePineAP_Settings", "PUT", "pineap/settings", typeof(BooleanResult)) },
            {"GetSSIDs", new Command("GetSSIDs", "GET", "pineap/ssids", typeof(ServiceSetIDs)) },
            {"Delete_All_SSIDs", new Command("Delete_All_SSIDs", "DELETE", "pineap/ssids", typeof(BooleanResult)) },
            {"AddSSID", new Command("AddSSID", "PUT", "pineap/ssids/ssid", typeof(BooleanResult)) },
            {"DeleteSSID", new Command("DeleteSSID", "DELETE", "pineap/ssids/ssid", typeof(BooleanResult)) },
            {"GetCapturedHandshakes", new Command("GetCapturedHandshakes", "GET", "pineap/handshakes", typeof(Handshakes)) }
            
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

using PineAPI.API.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineAPI
{
    public class PineappleAPI
    {

        public PineappleAPI()
        {
            Config.LoadConfig();
        }

        /// <summary>
        /// Executes a API command on a passing the resulting JsonObject To the Callback Function.
        /// </summary>
        /// <param name="cmd">the command to run</param>
        /// <param name="cb">Function Pointer to callback</param>
        /// <param name="_params">parameters needed by commands</param>
        /// <returns></returns>
        public bool DoCommand<T>(Commands cmd, Func<object, bool> cb, string JsonString = null, object[] _params = null)
        {
            return CommandMgr.ExecCommand<T>(cmd.ToString(), cb, JsonString, _params);
        }


        public enum Commands
        {
            LOGIN,
            SendNotification,
            Get_All_Notification,
            DeleteAllNotifications,
            Read_All_Notifications,
            DeleteNotification,
            ReadNotification,
            DispalyedNotification,
            Reboot,
            Shutdown,
            DeviceStatus,
            GetDeviceType,
            DownloadFile,
            GetStats,
            GetPineAP_Settings,
            UpdatePineAP_Settings,
            GetSSIDs,
            Delete_All_SSIDs,
            AddSSID,
            DeleteSSID,
            GetCapturedHandshakes
        }
    }
}

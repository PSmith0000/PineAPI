using PineAPI.API.JsonObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PineAPI
{
    public class Config
    {
        public static string LoginCombo = "";
        public static string Token = "";
        public static string GateWay = "";

        public static bool LoadConfig()
        {
            if (!Directory.Exists(Application.StartupPath + @"\Config"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\Config");
            }
            if (!File.Exists(Application.StartupPath + @"\Config\cfg.ini"))
            {
                File.Create(Application.StartupPath + @"\Config\cfg.ini").Dispose();
                File.WriteAllText(Application.StartupPath + @"\Config\cfg.ini", Encoding.Default.GetString(new byte[] { 0x4c, 0x6f, 0x67, 0x69, 0x6e, 0x3d, 0x7b, 0x22, 0x75, 0x73, 0x65, 0x72, 0x6e, 0x61, 0x6d, 0x65, 0x22, 0x3a, 0x22, 0x72, 0x6f, 0x6f, 0x74, 0x22, 0x2c, 0x20, 0x22, 0x70, 0x61, 0x73, 0x73, 0x77, 0x6f, 0x72, 0x64, 0x22, 0x3a, 0x22, 0x59, 0x4f, 0x55, 0x52, 0x5f, 0x50, 0x41, 0x53, 0x53, 0x57, 0x4f, 0x52, 0x44, 0x22, 0x7d, 0x0a, 0x47, 0x61, 0x74, 0x65, 0x77, 0x61, 0x79, 0x3d, 0x31, 0x37, 0x32, 0x2e, 0x31, 0x36, 0x2e, 0x34, 0x32, 0x2e, 0x31, 0x3a, 0x31, 0x34, 0x37, 0x31 }));
                Console.WriteLine("");
                return false;
            }

            string config = File.ReadAllText(Application.StartupPath + @"\Config\cfg.ini");

            var LoginData = Regex.Match(config, "n=.*");
            var GateWayData = Regex.Match(config, "y=.*");

            LoginCombo = LoginData.Value.Substring(2);
            GateWay = GateWayData.Value.Substring(2);

            return true;
        }
    }
}

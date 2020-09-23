using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PineAPI;
using PineAPI.API.JsonObjects;
namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            PineappleAPI api = new PineappleAPI();
            api.DoCommand<PineAPI.API.JsonObjects.AuthToken>(PineappleAPI.Commands.LOGIN, DataOpt);
            Console.WriteLine("Token Set");
            Console.Read();
          

            while (true)
            {

            }
        }

        static bool DataOpt(object data)
        {
            PineAPI.API.JsonObjects.AuthToken t = (PineAPI.API.JsonObjects.AuthToken)data;
            Config.Token = t.Token;
            return false;
        }

        static bool _DataOpt(object data)
        {
            var RESULT = (BooleanResult)data;
            Console.WriteLine(RESULT.Success);
            return false;
        }

        static bool __DataOpt(object data)
        {
            var RESULT = (BooleanResult)data;
            Console.WriteLine("Executed: " + RESULT.Success);
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace learning_dotnet_core_web_api.Filters
{
    public class Common
    {
        public static void TraceCaller([CallerMemberName] string memberName = "")
        {
            Console.WriteLine("Member Name: " + memberName);
        }
    }
}

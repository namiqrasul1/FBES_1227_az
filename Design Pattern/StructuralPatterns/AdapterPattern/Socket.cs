using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Socket
    {
       public void PowerGone(ITool tool)
        {
            int volt = tool.PowerOn();
            Console.WriteLine($"{volt} Volt power suplied");
        }
    }
}

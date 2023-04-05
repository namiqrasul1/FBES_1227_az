using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Dishwasher : ITool
    {
        private int volt;
        public Dishwasher()
        {
            volt = 220;
        }
        public int PowerOn()
        {
            Console.WriteLine("Dishwasher Working...");
            return volt;
        }
    }
}

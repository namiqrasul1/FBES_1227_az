using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Fridge : ITool
    {
        private int volt;
        public Fridge()
        {
            volt = 220;
        }

        public int PowerOn()
        {
            Console.WriteLine("Fridge Working...");
            return volt;
        }
    }
}

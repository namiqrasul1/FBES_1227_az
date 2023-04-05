using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Samsung : IPhone
    {
        private int phoneVoltage = 10;

        public int Charge()
        {
            Console.WriteLine("Samsung Charging...");
            return phoneVoltage;    
        }
    }
}

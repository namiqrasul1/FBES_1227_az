using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDP
{
    public class NumLockOn : IClickButton
    {
        public void Click0()
        {
            Console.WriteLine("0");
        }

        public void Click2()
        {
            Console.WriteLine("2");
        }

        public void Click4()
        {
            Console.WriteLine("4");
        }

        public void Click6()
        {
            Console.WriteLine("6");
        }

        public void Click8()
        {
            Console.WriteLine("8");
        }
    }
}

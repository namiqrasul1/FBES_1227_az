using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDP
{
    public class NumLockOff : IClickButton
    {
        public void Click0()
        {
            Console.WriteLine("Insert");
        }

        public void Click2()
        {
            Console.WriteLine("Down");
        }

        public void Click4()
        {
            Console.WriteLine("Left");
        }

        public void Click6()
        {
            Console.WriteLine("Right");
        }

        public void Click8()
        {
            Console.WriteLine("Up");
        }
    }
}

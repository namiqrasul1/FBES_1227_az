using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    public class Iphone : Phone
    {
        public int GetCameraCount()
        {
            return 2;
        }

        public string GetName()
        {
            return "Iphone ";
        }

        public double GetPrice()
        {
            return 900;
        }
    }
}

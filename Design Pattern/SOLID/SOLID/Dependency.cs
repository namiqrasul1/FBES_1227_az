using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Sigarette
    {

    }
    class Sobranie : Sigarette
    {

    }

    class Winston : Sigarette { }
    class Namig
    {
        public void Smoke(Sigarette sobranie)
        {

        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Namig obj = new();
    //        obj.Smoke(new Sobranie());
    //    }
    //}
}

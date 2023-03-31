using AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concretes
{
    internal class ModernSofa : Sofa
    {
        public override void WhoAreYou() => Console.WriteLine("ModernSofa");
    }
}

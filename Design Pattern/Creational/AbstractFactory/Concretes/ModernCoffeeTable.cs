using AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concretes
{
    internal class ModernCoffeeTable : CoffeeTable
    {
        public override void WhoAreYou() => Console.WriteLine("ModernCoffeeTable");
    }
}

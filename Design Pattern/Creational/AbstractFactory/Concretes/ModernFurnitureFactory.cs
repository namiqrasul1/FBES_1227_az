using AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concretes
{
    internal class ModernFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair() => new ModernChair();

        public CoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();

        public Sofa CreateSofa() => new ModernSofa();
    }
}

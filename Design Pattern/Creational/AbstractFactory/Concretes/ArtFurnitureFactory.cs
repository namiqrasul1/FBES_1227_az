using AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concretes
{
    internal class ArtFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair() => new ArtChair();
        public CoffeeTable CreateCoffeeTable()
        {
            throw new NotImplementedException();
        }

        public Sofa CreateSofa() => new ArtSofa();
    }
}

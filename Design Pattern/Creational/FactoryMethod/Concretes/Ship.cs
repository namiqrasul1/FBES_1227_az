using FactoryMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concretes
{
    internal class Ship : ITransport
    {
        public void Deliver() => Console.WriteLine("Deliver by Ship");
    }
}

using AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concretes
{
    internal class ArtChair : Chair
    {
        public override void WhoAreYou() => Console.WriteLine("ArtChair");
    }
}

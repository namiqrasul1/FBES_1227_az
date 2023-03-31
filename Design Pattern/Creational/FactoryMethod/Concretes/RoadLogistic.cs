using FactoryMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concretes
{
    internal class RoadLogistic : Logistic
    {
        public override void PlanDelivery() => Console.WriteLine("RoadLogistic");
        public override ITransport CreateTransport() => new Truck();
    }
}

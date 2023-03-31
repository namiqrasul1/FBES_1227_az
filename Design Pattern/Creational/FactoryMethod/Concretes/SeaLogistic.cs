using FactoryMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concretes
{
    internal class SeaLogistic : Logistic
    {
        public override void PlanDelivery() => Console.WriteLine("Sea");
        public override ITransport CreateTransport() => new Ship();
    }
}

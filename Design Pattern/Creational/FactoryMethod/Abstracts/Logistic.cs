using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Abstracts
{
    internal abstract class Logistic
    {
        public virtual void PlanDelivery() => Console.WriteLine("Logistic");
        public abstract ITransport CreateTransport();
    }
}

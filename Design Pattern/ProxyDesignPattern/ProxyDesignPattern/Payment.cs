using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal class Payment : IPayment
    {
        public bool Pay(decimal amount)
        {
            Console.WriteLine($"{amount} $ being paid...");
            return true;
        }
    }
}

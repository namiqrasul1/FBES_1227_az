using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal interface IPayment
    {
        bool Pay(decimal amount);
    }
}

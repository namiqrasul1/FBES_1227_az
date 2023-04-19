using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Bank : IBank
    {
        //protection
        //logging
        //virtual
        //caching
        public void SendMoney(double amount)
        {
            Console.WriteLine($"Transaction is succesfully finished : {amount}");
        }
    }
}

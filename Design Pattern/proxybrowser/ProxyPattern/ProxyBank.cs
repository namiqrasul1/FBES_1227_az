using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyBank : IBank
    {
        private Bank? bank;

        private string username;

        private string password;

        public ProxyBank(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool CheckUser()
        {
            if (username == "islam" && password == "islam123")
                return true;
            else
                return false;
        }

        public void SendMoney(double amount)
        {
            if (CheckUser())
            {
                bank = new Bank();
                bank.SendMoney(amount);
            }
            else
                Console.WriteLine("Username or password is invalid");
        }
    }
}

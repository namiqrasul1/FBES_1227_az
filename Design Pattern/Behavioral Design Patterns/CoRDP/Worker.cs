using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRDP
{
    public class Worker : Employee
    {
        public Worker(string? name) : base(name)
        {
        }

        public override void Process(Withdraw wit)
        {
            if (wit.Amount < 200)
                Console.WriteLine($"{Name} terefinden verildi\nId:{wit.Id}\nMiqdar:{wit.Amount}");
            else
            {
                Console.WriteLine($"Yonlendirildi : {Next?.Name}");
                Next?.Process(wit);
            }
        }

        public override void SetNext(Employee employee)
        {
            Next = employee;
        }
    }
}

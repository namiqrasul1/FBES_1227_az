using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRDP
{
    public class Ceo : Employee
    {
        public Ceo(string? name) : base(name)
        {
        }

        public override void Process(Withdraw wit)
        {
            if (wit.Amount <= 800)
                Console.WriteLine($"{Name} terefinden verildi\nId:{wit.Id}\nMiqdar:{wit.Amount}");
            else
                Console.WriteLine("Qaqa yoxdu");
        }

        public override void SetNext(Employee employee)
        {
            Next = employee;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRDP
{
    public abstract class Employee 
    {

        public Employee? Next;

        protected Employee(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }
        public abstract void SetNext(Employee employee);
        public abstract void Process(Withdraw wit);

    }
}

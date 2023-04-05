using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDP.Abstracts
{
    public abstract class Soldier
    {
        protected string _name;
        protected string _rank;
        protected Soldier(string name, string rank)
        {
            _name = name;
            _rank = rank;
        }

        public abstract void AddSoldier(Soldier soldier);

        public abstract void RemoveSoldier(Soldier soldier);

        public abstract void ExecuteCommand();

    }
}

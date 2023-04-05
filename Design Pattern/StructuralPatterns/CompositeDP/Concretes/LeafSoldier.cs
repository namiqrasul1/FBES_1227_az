using CompositeDP.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDP.Concretes
{
    internal class LeafSoldier : Soldier
    {
        public LeafSoldier(string name, string rank) : base(name, rank)
        {

        }

        public override void ExecuteCommand()
        {
            Console.WriteLine($"{_name} : {_rank}");
        }

        public override void AddSoldier(Soldier soldier)
        {
            throw new NotImplementedException();
        }

        public override void RemoveSoldier(Soldier soldier)
        {
            throw new NotImplementedException();
        }
    }
}

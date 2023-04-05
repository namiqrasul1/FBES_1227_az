using CompositeDP.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDP.Concretes
{
    public class CompositeSoldier : Soldier
    {
        public List<Soldier> Soldiers = new();
        public CompositeSoldier(string name, string rank) : base(name, rank)
        {
        }
        public override void AddSoldier(Soldier soldier)
        {
            Soldiers.Add(soldier);
        }

        public override void RemoveSoldier(Soldier soldier)
        {
            Soldiers.Remove(soldier);
        }
        public override void ExecuteCommand()
        {
            Console.WriteLine($"{_name} : {_rank}");
            foreach (var item in Soldiers)
            {
                item.ExecuteCommand();
            }
        }
    }
}

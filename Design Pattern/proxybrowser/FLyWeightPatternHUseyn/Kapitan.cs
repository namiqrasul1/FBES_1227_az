using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLyWeightPatternHUseyn
{
    public class Kapitan :Soldier
    {
        public Kapitan()
        {
            UnitName = "XTQ";
            Guns = "Rpk 74";
            Health = "Good";
        }
        public override void MoveTo(int x, int y)
        {
            X = x;
            Y = y;

            Console.WriteLine("Kapitan {0} : {1} koordinatina hereket edir", X, Y);
            Console.WriteLine(Guns);
        }
    }
}

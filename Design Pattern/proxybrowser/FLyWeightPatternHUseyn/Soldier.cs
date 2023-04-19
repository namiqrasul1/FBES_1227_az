using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLyWeightPatternHUseyn
{
    public abstract class Soldier
    {
        protected string UnitName;
        protected string Guns;
        protected string Health;


        protected int Y;
        protected int X;

        public abstract void MoveTo(int x,int y);

    }
}

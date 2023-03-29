using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    abstract class Fruit
    {
        public abstract string GetColor();
    }
    class Apple : Fruit
    {
        public override string GetColor() => "green";
    }

    class Orange : Fruit
    {
        public override string GetColor() => "orange";
    }
}

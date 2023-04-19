using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Fly_WeightA
{
    internal class Car
    {
        public string? Brand { get; set; } 
        public string? Model { get; set; } 
        public int? Year { get; set; }

        public override string ToString()
        {
            return $"{Brand} {Model} {Year} ";
        }
    }
}

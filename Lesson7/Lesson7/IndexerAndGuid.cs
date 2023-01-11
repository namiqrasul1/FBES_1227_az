using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Car
    {
        public Guid Id { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }

        public override string ToString() => $"{Vendor} {Model}";
    }

    internal class ShowRoom
    {
        public List<Car> Cars { get; set; } = new List<Car>();

        public Car this[int index] { get => Cars[index]; set => Cars[index] = value; }
        //public Car this[int index] => Cars[index];
    }
}

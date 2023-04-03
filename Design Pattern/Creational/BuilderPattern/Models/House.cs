using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    internal class House
    {
        //public House(string name, int walls, int windows, int rooms, int doors, bool hasGarrage, bool hasRoof, bool hasGarden, bool hasPool)
        //{
        //    Name = name;
        //    Walls = walls;
        //    Windows = windows;
        //    Rooms = rooms;
        //    Doors = doors;
        //    HasGarrage = hasGarrage;
        //    HasRoof = hasRoof;
        //    HasGarden = hasGarden;
        //    HasPool = hasPool;
        //}

        public string Name { get; set; }
        public int Walls { get; set; }
        public int Windows { get; set; }
        public int Rooms { get; set; }
        public int Doors { get; set; }
        public bool HasGarrage { get; set; }
        public bool HasRoof { get; set; }
        public bool HasGarden { get; set; }
        public bool HasPool { get; set; }

        public override string ToString()
        {
            return @$"Name: {Name}
Walls: {Walls}
Windows: {Windows}
Doors: {Doors}
Rooms: {Rooms}
Garden: {HasGarden}
SP: {HasPool}
Roof: {HasRoof}
Garrage: {HasGarrage}
";
        }
    }
}

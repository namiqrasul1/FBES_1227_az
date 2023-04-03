using BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builders
{
    internal interface IHouseBuilder
    {
        House House { get; set; }
        IHouseBuilder BuildWalls(int count);
        IHouseBuilder BuildWindows(int count);
        IHouseBuilder BuildDoors(int count);
        IHouseBuilder BuildRooms(int count);
        IHouseBuilder BuildGarden();
        IHouseBuilder BuildGarrage();
        IHouseBuilder BuildRoof();
        IHouseBuilder BuildPool();
        IHouseBuilder Reset();

        House GetHouse();
    }
}

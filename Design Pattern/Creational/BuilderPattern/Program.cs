using BuilderPattern.Builders;
using BuilderPattern.Models;

//House house = new House("dash", 4, 2, 1, 1, false, false, false, true);

IHouseBuilder hb = new StoneHouseBuilder();

var house = hb.BuildRooms(1).BuildWindows(2).BuildPool().BuildGarrage().GetHouse();

Console.WriteLine(house);

hb.Reset();

var anotherHouse = hb.BuildRooms(5).BuildGarden().GetHouse();
Console.WriteLine(anotherHouse);
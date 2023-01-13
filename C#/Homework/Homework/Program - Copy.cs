using Homework;

// main

PetShop shop = new();
shop.CatHouses.Add(new CatHouse { Name = "Ehmedli pishik evi" });
shop.CatHouses.Add(new CatHouse { Name = "Yasamal pishik evi" });
shop.CatHouses[0].AddCat(new Cat { Nickname = "Bahruz", Age = 1, Energy = 100, Gender = true, MealQuantity = 100, Price = 2 });
shop.CatHouses[0].AddCat(new Cat { Nickname = "Kamil", Age = 2, Energy = 100, Gender = false, MealQuantity = 100, Price = 2 });
shop.CatHouses[0].AddCat(new Cat { Nickname = "Hakuna", Age = 2, Energy = 100, Gender = true, MealQuantity = 100, Price = 2 });

while (true)
{
    Console.Clear();
    Console.WriteLine("1. PetShops");
    Console.WriteLine("2. Add CatHouse");
    Console.WriteLine("0. Exit");

    var key = Console.ReadKey();
    switch (key.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            Console.Clear();
            if (shop.CatHouseCount >= 0)
            {
                int i = 1;
                foreach (var house1 in shop.CatHouses)
                {
                    Console.WriteLine($"{i++}: {house1.Name}");
                }
                Console.WriteLine("enter any key");
                var cr = Console.ReadLine();
                if (int.TryParse(cr, out int result) && 0 <= result && result < shop.CatHouseCount)
                {
                    var house = shop.CatHouses[result - 1];
                    Console.Clear();
                    Console.WriteLine(house.Name);
                    Console.WriteLine("1. Butun pishikler");
                    Console.WriteLine("2. pishik elave et");
                    key = Console.ReadKey();
                    Console.Clear();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            i = 1;
                            foreach (var cat in house.Cats)
                            {
                                Console.WriteLine($"{i++}: {cat.Nickname}");
                            }
                            Console.ReadLine();
                            break;
                        default: break;
                    }
                }
            }
            else Console.WriteLine("Hal Hazirda Cat House yoxdur");
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            Console.Clear();
            Console.WriteLine("Evin Adi: ");
            var name = Console.ReadLine();
            CatHouse ch = new() { Name = name };
            shop.CatHouses.Add(ch); break;
        default:
            break;
    }
}
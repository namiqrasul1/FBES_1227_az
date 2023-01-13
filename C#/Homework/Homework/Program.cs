//using Homework;

//// main

//PetShop shop = new();
//shop.CatHouses.Add(new CatHouse { Name = "Ehmedli pishik evi" });
//shop.CatHouses.Add(new CatHouse { Name = "Yasamal pishik evi" });
//shop.CatHouses[0].AddCat(new Cat { Nickname = "Bahruz", Age = 1, Energy = 100, Gender = true, MealQuantity = 100, Price = 2 });
//shop.CatHouses[0].AddCat(new Cat { Nickname = "Kamil", Age = 2, Energy = 100, Gender = false, MealQuantity = 100, Price = 2 });
//shop.CatHouses[0].AddCat(new Cat { Nickname = "Hakuna", Age = 2, Energy = 100, Gender = true, MealQuantity = 100, Price = 2 });

//void mainMenu()
//{
//    Console.Clear();
//    Console.WriteLine("1. PetShops");
//    Console.WriteLine("2. Add CatHouse");
//    Console.WriteLine("0. Exit");

//    var key = Console.ReadKey();
//    switch (key.Key)
//    {
//        case ConsoleKey.D1:
//        case ConsoleKey.NumPad1:
//            ShowCatHouses();
//            break;
//        case ConsoleKey.D2:
//        case ConsoleKey.NumPad2:
//            AddCatHouse(); break;
//        default:
//            break;
//    }
//}

//void AddCatHouse()
//{
//    Console.Clear();
//    Console.WriteLine("Evin Adi: ");
//    var name = Console.ReadLine();
//    CatHouse house = new() { Name = name };
//    shop.CatHouses.Add(house);
//}

//void ShowCatHouse(CatHouse house)
//{
//    Console.Clear();
//    Console.WriteLine(house.Name);
//    Console.WriteLine("1. Butun pishikler");
//    Console.WriteLine("2. pishik elave et");
//    var key = Console.ReadKey();
//    Console.Clear();
//    switch (key.Key)
//    {
//        case ConsoleKey.D1:
//        case ConsoleKey.NumPad1:
//            int i = 1;
//            foreach(var cat in house.Cats)
//            {
//                Console.WriteLine($"{i++}: {cat.Nickname}");
//            }
//            Console.ReadLine();
//            break;
//        default: break;
//    }
//}

//void ShowCatHouses()
//{
//    Console.Clear();
//    if (shop.CatHouseCount >= 0)
//    {
//        int i = 1;
//        foreach (var house in shop.CatHouses)
//        {
//            Console.WriteLine($"{i++}: {house.Name}");
//        }
//        Console.WriteLine("enter any key");
//        var key = Console.ReadLine();
//        if (int.TryParse(key, out int result) && 0 <= result && result < shop.CatHouseCount)
//        {
//            ShowCatHouse(shop.CatHouses[result - 1]);
//        }
//    }
//    else Console.WriteLine("Hal Hazirda Cat House yoxdur");
//}

//while (true)
//{
//    mainMenu();
//}
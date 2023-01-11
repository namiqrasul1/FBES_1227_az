using Lesson7;

//var result = Calc.Mult(4, 2,123);
//Console.WriteLine(result);

//AnyClass obj = new AnyClass();
//AnyClass o = new AnyClass(1);


//Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
//Console.WriteLine(Environment.CurrentDirectory);
//Console.WriteLine(Environment.MachineName);
//Console.WriteLine(Environment.UserName);
//Console.WriteLine(Environment.OSVersion);

//Point p = new() { X = 12, Y = 10 };
//Point p1 = new() { X = 10, Y = 12 };
//Console.WriteLine(p == p1);

//Point result = p + p1;
//result = -p;
//Console.WriteLine(result);
//Guid id;
//while (true)
//{
//    id = Guid.NewGuid();
//    Console.WriteLine(id);
//}

ShowRoom sr = new();
sr.Cars.Add(new() { Id = Guid.NewGuid(), Vendor = "lada", Model = "supra" });
sr.Cars.Add(new() { Id = Guid.NewGuid(), Vendor = "bmw", Model = "2107" });
sr.Cars.Add(new() { Id = Guid.NewGuid(), Vendor = "mercedes", Model = "prius" });
sr.Cars.Add(new() { Id = Guid.NewGuid(), Vendor = "toyota", Model = "elantra" });
sr[2].Vendor = "merc";


sr[1] = new Car() { Id = Guid.NewGuid(), Vendor = "Hundai", Model = "Getdiyin yollari deyish" };
Console.WriteLine(sr[2]);
using PrototypeSingleton;

//President president = new() { Name = "Angela", Surname = "Marker", Height = 1.65, Country = "Bizi qisqanan Almanya" };

//President president1 = new() { Name = "Angela", Surname = "Marker", Height = 1.65, Country = "Bizi qisqanan Almanya" };

//president.Name = "Kamil";

//Console.WriteLine(president1);

//President president = President.GetPresident();
//Console.WriteLine(president);

//President pre = President.GetPresident();
//pre.Country = "Azerbaycan";
//Console.WriteLine(president);

Book book = new() { Name = "Ayshan Gezintide", Author = "Nigar", PublishYear = 2023 };
Book? b = book.Clone() as Book;
b.Name = "Ayshan Qardashim Tedbirinde";
Console.WriteLine(book.Name);
Console.WriteLine(b.Name);
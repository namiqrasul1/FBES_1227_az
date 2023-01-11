using Abstraction;
using Abstraction.Databases;
using Abstraction.Models;

//Animal[] animals = new Animal[]
//{
//    new Bird(),
//    new Bird(),
//    new Ronaldo(),
//    new Wolf(),
//    new Ronaldo(),
//    new Bird(),
//    new Ronaldo(),
//    new Bird(),
//    new Wolf(),
//    new Wolf(),
//    new Ronaldo(),
//    new Wolf(),
//    new Wolf(),
//};

List<Animal> animals = new()
{
   new Bird(),
   new Bird(),
   new Ronaldo(),
   new Wolf(),
   new Ronaldo(),
   new Bird(),
   new Ronaldo(),
   new Bird(),
   new Wolf(),
   new Wolf(),
   new Ronaldo(),
   new Wolf(),
   new Wolf(),
};

var bird = new Bird();
animals.Add(new Wolf());
animals.Add(bird);

var index = animals.IndexOf(bird);
animals.RemoveAt(index);
foreach (var animal in animals)
{
    //if (animal is Ronaldo)
        animal.Speak();
}

//Database db = new PostgreSql();
//App app = new(db);
//Data data = new() { Id = 1, Name = "Kamil" };
//app.Database.Create(data);

//app.Database = new MsSql();

//app.Database.Update(1);
//Data? d = app.Database.Read(1);

//app.Database.Delete(1);
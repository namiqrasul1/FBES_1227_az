using Fly_WeightA;

CarFactory carFactory = new();

carFactory.GetCar("tesla", "model x", 2023);

foreach (var item in carFactory.cars)
{
    Console.WriteLine(item);
}
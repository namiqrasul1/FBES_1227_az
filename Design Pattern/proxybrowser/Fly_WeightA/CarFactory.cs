using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly_WeightA
{
    internal class CarFactory
    {
        public List<Car> cars = new();


        public Car GetCar(string brand, string model, int year)
        {

            var car = cars.FirstOrDefault(c => c.Year == year && c.Brand == brand && c.Model == model);

            if (car == null)
            {
                car = new Car() { Model = model, Year = year, Brand = brand };
                cars.Add(car);

            }
            return car;
        }

        

    }
}

using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /// <summary>
    /// Bad Example
    /// </summary>
    //internal class Circle
    //{
    //    public double Radius { get; set; }
    //}

    //internal class Rectangle
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }
    //}

    //class Triangle
    //{
    //    // some code
    //}

    //class Calc
    //{
    //    public double CalculateArea(object figure)
    //    {
    //        double area = 0;
    //        if (figure is Rectangle r)
    //            area = r.Height * r.Width;
    //        else if (figure is Circle c)
    //            area = c.Radius * c.Radius * 3.14;


    //        return area;
    //    }
    //}


    /// <summary>
    /// Good Example
    /// </summary>
    /// 

    abstract class Figure
    {
        public abstract double GetArea();
    }

    internal class Circle : Figure
    {
        public double Radius { get; set; }

        public override double GetArea() => Radius * Radius * 3.14;
    }

    internal class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double GetArea() => Width * Height;
    }

    class Tringle : Figure
    {
        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }


    class Calc
    {
        public double CalculateArea(Figure figure)
        {
            return figure.GetArea();
        }
    }

    /// <summary>
    /// Bad Example
    /// </summary>

    abstract class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public abstract double GetBonus();
    }

    class JuniorDeveloper : Developer
    {
        public override double GetBonus() => Salary * 0.1;
    }

    class MidDev : Developer
    {
        public override double GetBonus() => Salary * 0.2;
    }

    class SenDev : Developer
    {
        public override double GetBonus() => Salary * 0.35;
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Developer> developers = new();
    //        developers.Add(new SenDev() { Id = 1, Name = "Kamil", Salary = 1500 });
    //        developers.Add(new MidDev() { Id = 1, Name = "Kamil", Salary = 1500 });
    //        developers.Add(new JuniorDeveloper() { Id = 1, Name = "Kamil", Salary = 1500 });
    //        foreach (var dev in developers)
    //        {
    //            Console.WriteLine(dev.GetBonus());
    //        }
    //    }
    //}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator +(Point p, Point p1)
        {
            return new Point() { X = p.X + p1.X, Y = p.Y + p1.Y };
        }

        public static Point operator -(Point p)
        {
            return new() { X = -p.X, Y = -p.Y };
        }

        public static bool operator ==(Point p, Point p1)
        {
            return p.Equals(p1);
        }

        public static bool operator !=(Point p, Point p1)
        {
            return p.X != p1.X && p.Y != p1.Y;
        }

        public override bool Equals(object? obj)
        {
            return ToString() == obj?.ToString();
        }

        public override string ToString() => $"{X} {Y}";
    }
}

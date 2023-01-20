using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    // Action    => return type is void
    // Func      => return type is all types without void
    // Predicate => return type is bool

    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BDate { get; set; }

        public override string ToString()
            => $"{Name} {Surname} {BDate.ToShortDateString()}";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Some some = new();
            #region Action

            //Action action = some.Foo;
            //action();
            //Action<int> action = some.Method;
            //action.Invoke(5);

            #endregion

            #region Func

            //Func<int, double, string> func = some.Sum;
            //var s = func(1, 2);


            #endregion
            List<Student> students = new()
            {
                new() { Name = "Ruso", Surname = "Mamo", BDate = new(1891, 06, 06) },
                new() { Name = "Iso", Surname = "Salo", BDate = new(1891, 06, 06) },
                new() { Name = "Raso", Surname = "Sabo", BDate = new(1891, 06, 06) },
                new() { Name = "Niga", Surname = "Muso", BDate = new(1891, 06, 06) },
                new() { Name = "Baho", Surname = "Nazo", BDate = new(1891, 06, 06) },
                new() { Name = "Azo", Surname = "Sulo", BDate = new(1891, 06, 06) },
                new() { Name = "Saxa", Surname = "Tano", BDate = new(1891, 06, 06) }
            };

            Predicate<Student> predicate = delegate (Student st) { return st.Name.Length > 3; };
            students.RemoveAll(predicate);

            students.ForEach(delegate (Student student)
            {
                student.BDate = student.BDate.AddYears(100);
            });

            students.ForEach(delegate (Student st) { Console.WriteLine(st); });

            //foreach (var st in students)
            //{
            //    Console.WriteLine(st);
            //}
        }

        class Some
        {
            public void Foo() { Console.WriteLine("Foo()"); }
            public void Method(int i) { Console.WriteLine($"Method({i})"); }
            public string Sum(int arg, double arg1) => (arg + arg1).ToString();
        }
    }
}

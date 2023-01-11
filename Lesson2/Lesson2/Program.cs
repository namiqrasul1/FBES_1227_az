using System.ComponentModel.Design;

namespace Lesson2
{
    internal class Program
    {
        enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            #region Console

            //Console.WriteLine("asdasda");
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.Write("asdasda");
            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.Write("asdasda");

            //ConsoleKeyInfo key =  Console.ReadKey();
            //while (true)
            //{
            //    var key = Console.ReadKey();
            //    Console.WriteLine();
            //    Console.WriteLine(key.Key);
            //    if (key.Key == ConsoleKey.Escape) 
            //        break;
            //}

            #endregion
            #region Enum
            //Console.WriteLine((int)Days.Wednesday);
            //int day = (int)Days.Saturday;
            //Console.WriteLine(day);
            #endregion

            #region MyRegion

            //int n = 1;
            //int n1 = n;
            //n = 42;
            //Console.WriteLine(n1);

            //double d = default;
            //double d = double.MinValue;
            //Console.WriteLine(d);

            //int i = 12;
            //i.CompareTo(12);

            //char c = '1';
            //double d = 12.3;
            //float f = Convert.ToSingle(d);
            //Console.WriteLine(f);

            #endregion

            // ref | out (keyword)

            //int n = 42;
            //Change(n);
            //ChangeWithRefKeyword(ref n); // variable mutleq shekilde initalize olunmush olmalidir.
            //ChangeWithOutKeyword(out n);
            //ChangeWithOutKeyword(out int n);
            //Console.WriteLine(n);

            // in
            //int i = 1;
            //Foo(i);
            //string input = Console.ReadLine();
            //int age = int.Parse(input);


            //int age = int.Parse(Console.ReadLine()); // problem

            //int age;
            //int.TryParse(Console.ReadLine(), out age);
          
            //bool result = int.TryParse(Console.ReadLine(), out int age);
            _ = int.TryParse(Console.ReadLine(), out int age);

            int.TryParse(Console.ReadLine(), out _);
            Console.WriteLine("Age" + 12);
            Console.WriteLine($"Age {age}");
            Console.WriteLine("Age {1} {0}", age, 98);
        }

        private static void Foo(in int i)
        {
            //i = 12; // olmaz chunki readonlydir
        }

        private static void ChangeWithOutKeyword(out int i)
        {
            i = 12; // out parameterle qebul olunan variable mutleq shekilde function icherisinde initalize olunmalidir.
        }
        private static void ChangeWithRefKeyword(ref int i)
        {
            i = 12;
        }
        private static void Change(int i)
        {
            i = 12;
        }
    }
}
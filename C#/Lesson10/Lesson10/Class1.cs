using System.Collections;

namespace Lesson10
{


    internal class Program
    {
        static void Main(string[] args)
        {
            // non-generic 
            //ArrayList al = new();
            //al.Add(1);
            //al.Add("rustam");
            //al.Add(new Program());
            //int? i = al[0] as int?;
            //// ? => nullable
            //// ? => null conditional

            //ArrayList al = new();
            //al.Add(1);
            //al.Add(2);
            //al.Add(3);
            //al.Add("hakuna");
            //al.Add(5);
            //al.Add(7);

            //foreach (object item in al)
            //{
            //    Console.WriteLine(item);
            //}

            //var enumerator = al.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}
            //enumerator.Reset();
            //enumerator.MoveNext();
            //Console.WriteLine(enumerator.Current);

            // boxing   => value type -> reference type  
            // unboxing => reference type -> value type

            // generic
            //List<int> l = new() { 1, 23, 123, 12, 312, 4523, 5 };
            //List<int> list = new();
            //list.Add(1);   
            //list.Add(2);   
            //list.Add(4);   
            //list.Add(56);   
            //list.Add(7);
            //list.AddRange(l);
            //list.RemoveRange(5, 4);
            //list.Remove(1);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);    
            //}
            

            Dictionary<string, string> capitals = new();
            capitals.Add("Aze", "Baku");
            capitals.Add("Eng", "London");
            capitals.Add("Canada", "Ottawa");
            Console.WriteLine(capitals["Aze"]);
            foreach (var item in capitals)
            {
                Console.WriteLine(item);
            }

        }
    }
}

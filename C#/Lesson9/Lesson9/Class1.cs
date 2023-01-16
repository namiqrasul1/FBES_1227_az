//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson9;

//public interface IA
//{
//    public int MyProperty { get; set; }
//}

//public class Some : IA
//{
//    //public int field;
//    //public int MyProperty { get => field; set => field = value; }
//    public int MyProperty { get; set; }

//}


//class Program
//{
//    static void Main(string[] args)
//    {
//        IA obj = new Some();
//        obj.MyProperty = 1;
//        Console.WriteLine(obj.MyProperty);
//        if(obj is Some s)
//        {
//            Console.WriteLine(s.MyProperty);
//        }
//    }
//}
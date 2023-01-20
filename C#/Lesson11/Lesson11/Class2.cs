//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson11
//{
  
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //MyDelegate del = new(Foo);
//            //MyDelegate del = Foo;
//            //del.Invoke(6);
//            //del(5);
//            //Some(Foo);

//            //Some(Foo);

//            // =  init
//            // += subscribe
//            // -= unsubscribe

//            MyDelegate del = Foo;
//            del += Goo;
//            del += Boo;
//            //del -= Foo;
//            //del = Goo;
//            //del();

//            foreach (Delegate method in del.GetInvocationList())
//            {
//                if (method.Method.Name == "Foo")
//                    method.DynamicInvoke();
//            }

//            //MyDelegateWithInt delegateWithInt = Foo;
//            //delegateWithInt.Invoke(7);
//            //delegateWithInt(5);

//        }
//        // int(*ptr)(params)
//        delegate void MyDelegate();
//        delegate void MyDelegateWithInt(int arg);
//        static void Some(MyDelegate del)
//        {
//            del();
//        }
//        static void Foo() { Console.WriteLine("Foo"); }
//        static void Goo() { Console.WriteLine("Goo"); }
//        static void Boo() { Console.WriteLine("Boo"); }

//        static void Foo(int a) { Console.WriteLine($"Foo({a})"); }
//        static void Goo(int b) { Console.WriteLine($"Goo({b})"); }
//        static void Boo(int b) { Console.WriteLine($"Boo({b})"); }
//    }
//}

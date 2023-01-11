using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public static class SomeClass
    {
        public static int MyProperty { get; set; }
        public static int i;
        public const int constVar = 12;
        public static readonly int readOnlyVar;
        static SomeClass() // static constructor
        {
            readOnlyVar = 42;
        }

        public static void Foo() { Console.WriteLine(constVar); }
    }

    class AnyClass
    {
        int a;
        public AnyClass()
        {
            Console.WriteLine("Default");
        }
        public AnyClass(int a)
        {
            Console.WriteLine("With Params");
        }
        static AnyClass()
        {
            Console.WriteLine("Static");
        }
    }

}

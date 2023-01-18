//////string[,] strings = new string[2, 2]
//////{
//////    { "hakuna", "Matata" },
//////    { "john", "doe" }
//////};

//////Console.WriteLine(strings[0,0]);

////string[][] strings = new string[2][]
////{
////    new string[] { "hakuna", "matata" },
////    new string[] { "john", "doe" },
////};

////foreach (var item in strings[0])
////{
////}

//namespace Lesson10;

//class Program
//{
//    interface IA { }
//    class A : IA { }
//    class B : A { }
//    class C { }
//    static void  TemplateMethod1<T>(T arg) where T : IA, new()
//    {
//        Console.WriteLine(typeof(T).FullName);
//    }
//    static TResult? TemplateMethod<TResult,T>(T arg)  where TResult : class, new()
//    {
//        Console.WriteLine(typeof(T).FullName);
//        return null;
//    }
//    static void Main(string[] args)
//    {
//        //TemplateMethod1(new A());
//        //TemplateMethod<double, Program>(new Program());
//        //TemplateMethod<Program, double>(4.6);
//        //Some<int> some = new Some<int>();
//        //var some1 = new Some<int>();
//        //Some<string> some2 = new();
//        Pair<int, string> pair = new() { Key = 1, Value =  "Hakuna"};
//        Console.WriteLine(pair.Key);
//        Console.WriteLine(pair.Value);
//    }

//    class Pair<TKey, TValue>
//    {
//        public TKey Key { get; set; }
//        public TValue Value { get; set; }
//    }

//    class Some<T> where T : struct
//    {
//        public T MyProperty { get; set; }
//    }
//}
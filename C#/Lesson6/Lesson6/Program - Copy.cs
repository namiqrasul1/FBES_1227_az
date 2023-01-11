

namespace Lesson6
{
    partial class ClassA
    {
        public int Id { get; set; }
    }

    partial class ClassA
    {
        public void Show() => Console.WriteLine(Id);
    }

    class A
    {
        public virtual void Foo() => Console.WriteLine("A.Foo()");
    }

    sealed class B : A
    {
        public sealed override void Foo() => Console.WriteLine("B.Foo()");
    }

    class C : B // error
    {
        public override void Foo() => Console.WriteLine("C.Foo()");
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ClassA obj = new();
            //obj.Id = 12;
            //obj.Show();
            A obj = new C();
            obj.Foo();
        }
    }
}
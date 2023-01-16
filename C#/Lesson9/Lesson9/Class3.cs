namespace Lesson9;

interface IA
{
    void Foo();
}
interface IB
{
    void Foo();
}

class Some : IA, IB
{
    void IA.Foo() { Console.WriteLine("Some.IA.Foo()"); }
    public void Foo() { Console.WriteLine("Some.Foo()"); }
}

class Program
{
    static void Main(string[] args)
    {
        var o = new Some();
        IA ia = o;
        IB ib = o;
        ia.Foo();
        ib.Foo();
        o.Foo();
    }
}

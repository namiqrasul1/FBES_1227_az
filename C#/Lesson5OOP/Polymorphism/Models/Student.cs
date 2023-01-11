namespace Polymorphism.Models
{
    internal class Student : Person
    {
        public override void Foo()
        {
            Console.WriteLine("Student.Foo()");
        }
    }
}

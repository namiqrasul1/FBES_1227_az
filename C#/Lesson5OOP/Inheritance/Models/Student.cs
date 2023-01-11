namespace Inheritance.Models
{
    public class Student : Person
    {
        public double Avg { get; set; }

        public Student(string name, string surname, int age, double avg) : base(name, surname, age)
        {
            Avg = avg;
        }
        public override string ToString() => $"{Name} {Surname} {Age} {Avg}";

    }
}

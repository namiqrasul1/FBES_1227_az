using System.Security.Cryptography.X509Certificates;

namespace Lesson4
{
    //public class Student
    //{
    //    private int age;
    //    public int Age
    //    {
    //        get { return age; }
    //        set { age = 0 < value && value < 150 ? value : throw new Exception("Age is not valid"); }
    //    }

    //    public string Name { get; set; }
    //    public string Email { get; init; } = "sadas"; // initial 
    //}

    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Fullname { get => $"{Name} {Surname}"; }

        public Student()
        {

        }

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString() => $"{Fullname} {Age}";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new()
            //{
            //    Age = 14 // set
            //};
            //var age = student.Age; // get
            //Student student = new();
            //student.Email = "asdasd";

            //Student student = new();
            //var st = new Student
            //{
            //    Age = 12,
            //    Name = "hakuna",
            //    Surname = "matata"
            //};

            //Student student = new("hakuna", "suuuuuuuuuuu", 37);

            //Console.WriteLine(student);
            //var str = student.ToString();
            //Console.WriteLine(str);

            Student student = new("hakuna", "suuuuuuuuuuu", 37);
            Change(student);
            Console.WriteLine(student.Fullname);
        }

        static void Change(Student st)
        {
            st = new("Ronaldo", "suuuuuuuuuuu", 37);
        }
    }
}
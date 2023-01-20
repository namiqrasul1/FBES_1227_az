//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson11
//{
//    class Student : ICloneable, IComparable<Student>
//    {
//        public string Name { get; set; }
//        public string Surname { get; set; }
//        public DateTime BDate { get; set; }

//        public object Clone()
//            => new Student() { Name = Name, Surname = Surname, BDate = BDate };

//        public int CompareTo(Student? other)
//        {
//            return BDate.CompareTo(other?.BDate);
//        }
//    }

//    class Auditory : IEnumerable
//    {
//        public List<Student> Students { get; set; } = new()
//        {
//            new() { Name = "Ruso", Surname = "Mamo", BDate = new(1891, 06, 06) },
//            new() { Name = "Iso", Surname = "Salo", BDate = new(1891, 06, 06) },
//            new() { Name = "Raso", Surname = "Sabo", BDate = new(1891, 06, 06) },
//            new() { Name = "Niga", Surname = "Muso", BDate = new(1891, 06, 06) },
//            new() { Name = "Baho", Surname = "Nazo", BDate = new(1891, 06, 06) },
//            new() { Name = "Azo", Surname = "Sulo", BDate = new(1891, 06, 06) },
//            new() { Name = "Saxa", Surname = "Tano", BDate = new(1891, 06, 06) }
//        };

//        public IEnumerator GetEnumerator()
//            => Students.GetEnumerator();
//    }

//    internal class Program
//    {
//        static IEnumerable<int> GetNumbers()
//        {
//            yield return 1;
//            yield return 2;
//            yield return 3;
//            yield return 4;
//            yield return 5;
//            yield return 6;
//            yield return 7;
//        }

//        static void Main(string[] args)
//        {
//            //Student st = new() { Name = "Ruso", Surname = "Mamo", BDate = new(1891, 06, 06) };
//            //Student? s = st.Clone() as Student;
//            //s.Surname = "Mammadov";
//            //Console.WriteLine(st.Surname);

//            //var list = GetNumbers();

//            //foreach (var item in list)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            Auditory auditory = new();
//            foreach (Student student in auditory)
//            {
//                Console.WriteLine(student.Name);
//            }
//        }
//    }
//}

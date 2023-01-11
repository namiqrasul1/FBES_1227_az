namespace Encapsulation.Models
{
    internal class Person
    {
		private int age;

		public int Age
		{
			get { return age; }
			set { age = 0 < value && value < 150 ? value : throw new Exception("Age is not valid"); }
		}

		public string Name { get; set; }
	}
}

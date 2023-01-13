namespace Homework
{
    internal class Cat
    {
        public string Nickname { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public int Energy { get; set; }
        public double Price { get; set; }
        public int MealQuantity { get; set; }

        public void Eat()
        {
            if (MealQuantity == 100)
                Console.WriteLine("Toxdu");
            else
            {
                MealQuantity += 10;
                Console.WriteLine("Yeyir");
            }
        }
        public void Sleep()
        {
            if (Energy == 100)
            {
                Console.WriteLine("Yuxusu gelmir. Enerjilidi. Fulldu");
            }
            else
            {
                Energy = 100;
                Console.WriteLine("Yatir");
            }
        }
        public void Play()
        {
            if (Energy >= 10 && MealQuantity >= 10)
            {
                Console.WriteLine("Oynuyur");
                Energy -= 10;
                MealQuantity -= 10;
            }
            if (Energy <= 0)
            {
                Console.WriteLine("Yuxusu gelir");
            }
            if (MealQuantity <= 0)
            {
                Console.WriteLine("Acdi");
            }
        }

    }
}

namespace Homework
{
    internal class CatHouse
    {
        public string Name { get; set; }
        public List<Cat> Cats { get; set; } = new(); 
        public int CatCount { get => Cats.Count; }

        public void AddCat(Cat cat)
        {
            foreach(var item in Cats)
            {
                if (item.Nickname == cat.Nickname)
                    throw new Exception("Bele pishik var");
            }
            Cats.Add(cat);
        }

        public void RemoveByNickname(string nickname)
        {
            foreach (var item in Cats)
            {
                if(item.Nickname == nickname)
                    Cats.Remove(item);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class PetShop
    {
        public List<CatHouse> CatHouses { get; set; } = new List<CatHouse>();
        public int CatHouseCount { get=> CatHouses.Count; }
    }
}

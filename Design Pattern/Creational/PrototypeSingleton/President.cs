using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSingleton
{
    internal class President
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public double? Height { get; set; }
        public string? Country { get; set; }

        private static President? Presidentt { get; set; }
        
        private President() { }

        public static President GetPresident()
        {
            if (Presidentt == null)
                Presidentt = new President() { Name = "Ilham", Surname = "Aliyev", Height = 1.88, Country = "Dunyanin hesret apardigi oz seviyyesi olan Azerbaycan!!!" };
            return Presidentt;
        }

        public override string ToString() => $"{Name} {Surname} {Height} {Country}";
    }
}

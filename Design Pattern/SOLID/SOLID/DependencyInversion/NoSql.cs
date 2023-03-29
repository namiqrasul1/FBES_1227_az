using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    internal class NoSql : IDataBase
    {
        public void Add()
        {
            Console.WriteLine("Added to NoSql");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted from NoSql");
        }
    }
}

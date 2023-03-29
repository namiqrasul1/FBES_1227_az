using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    internal class MsSql : IDataBase
    {
        public void Add()
        {
            Console.WriteLine("Added to MsSql");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted from MsSql");
        }
    }
}

using Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Databases
{
    internal class PostgreSql : Database
    {
        public override void Create(Data data)
        {

            Console.WriteLine($"PostgreSql melumati elave etdi!");
        }

        public override bool Delete(int id)
        {
            Console.WriteLine($"PostgreSql {id}-li melumati sildi!");
            return true;
        }

        public override Data? Read(int id)
        {
            Console.WriteLine($"PostgreSql {id}-li melumati qaytardi!");
            return null;
        }

        public override void Update(int id)
        {
            Console.WriteLine($"PostgreSql {id}-li melumati deyishdirdi!");
        }
    }
}

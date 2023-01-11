using Abstraction.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class App
    {
        public Database Database { get; set; }

        public App(Database database)
        {
            Database = database;
        }
    }
}

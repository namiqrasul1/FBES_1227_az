using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    internal class Application
    {
        public IDataBase db;

        public Application(IDataBase db)
        {
            this.db = db;
        }

        public void Insert() => db.Add();
        public void Delete() => db.Delete();

    }
}

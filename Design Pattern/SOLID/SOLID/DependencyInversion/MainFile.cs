using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    internal class MainFile
    {
        static void Main(string[] args)
        {
            Application app = new(new NoSql());
            app.Insert();
            app.db = new MsSql();
            app.Delete();
        }
    }
}

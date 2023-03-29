using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    internal interface IDataBase
    {
        void Add();
        void Delete();
    }
}

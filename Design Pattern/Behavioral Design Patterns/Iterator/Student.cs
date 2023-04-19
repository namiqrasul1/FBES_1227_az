using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Student : IEnumerable
    {
        public string Name { get; set; }
        public List<string> Books { get; set; }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return Books.GetEnumerator();
        }
    }
}

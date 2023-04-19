using proxybrowser.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxybrowser.Concretes
{
    public class Browser : IBrowser
    {
        public void GetRequest(string request)
        {
            Console.WriteLine($"Database:{request}");
        }
    }
}

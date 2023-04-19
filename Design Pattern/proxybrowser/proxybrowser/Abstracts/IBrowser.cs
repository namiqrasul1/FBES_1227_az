using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxybrowser.Abstracts
{
    public interface IBrowser
    {
        public void GetRequest(string request);
    }
}

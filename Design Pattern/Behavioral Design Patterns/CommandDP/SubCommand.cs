using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    public class SubCommand : Calculate
    {
        Operation operation = new();
        public void Calculate(int x, int y)
        {
            operation.Sub(x, y);
        }
    }
}

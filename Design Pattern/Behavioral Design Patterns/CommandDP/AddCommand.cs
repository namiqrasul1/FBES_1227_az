using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    public class AddCommand : Calculate
    {
        Operation operation = new();
        public void Calculate(int x, int y)
        {
            operation.Add(x, y);
        }
    }
}

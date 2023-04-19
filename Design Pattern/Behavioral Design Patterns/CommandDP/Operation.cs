using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    public class Operation
    {
        public void Add(int a,int b)
        {
            int answer = a + b;
            Console.WriteLine(answer);
        }
        public void Sub(int a, int b)
        {
            int answer = a - b;
            Console.WriteLine(answer);
        }
        public void Div(int a, int b)
        {
            int answer = a / b;
            Console.WriteLine(answer);
        }
        public void Mult(int a, int b)
        {
            int answer = a * b;
            Console.WriteLine(answer);
        }
    }
}

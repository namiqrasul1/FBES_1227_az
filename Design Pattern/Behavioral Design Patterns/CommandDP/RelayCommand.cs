using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    internal class RelayCommand
    {
        Action<object> execute;

        public RelayCommand(Action<object> execute)
        {
            this.execute = execute;
        }

        public void Execute(object obj)
        {
            execute.Invoke(obj);
        }
    }
}

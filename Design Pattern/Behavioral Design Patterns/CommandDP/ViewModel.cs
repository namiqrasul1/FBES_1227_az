using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    internal class ViewModel
    {
        public RelayCommand SaveCommand { get; set; }

        public ViewModel()
        {
            SaveCommand = new((obj) => Console.WriteLine("Has been Saved"));
        }

    }
}

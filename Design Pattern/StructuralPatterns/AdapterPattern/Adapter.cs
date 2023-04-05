using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter : ITool
    {
        private IPhone phone;
        public Adapter(IPhone phone)
        {
            this.phone = phone;
        }

        public int PowerOn()
        {
            return phone.Charge();
        }
    }
}

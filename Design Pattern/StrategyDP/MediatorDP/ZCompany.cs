using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    internal class ZCompany : Company
    {
        public ZCompany(ITransfer transfer) : base(transfer)
        {
        }

        public override void StartTransport()
        {
            Console.WriteLine("Gubadan eshyalar ZCompany vasitesile yuklendi");
            _transfer.TransferFurniture(this);
        }
    }
}

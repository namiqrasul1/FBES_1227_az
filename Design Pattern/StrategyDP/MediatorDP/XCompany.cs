using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    internal class XCompany : Company
    {
        public XCompany(ITransfer transfer) : base(transfer)
        {
        }

        public override void StartTransport()
        {
            Console.WriteLine("Bakidan eshyalar XCompany vasitesile yuklndi");
            _transfer.TransferFurniture(this);
        }
    }
}

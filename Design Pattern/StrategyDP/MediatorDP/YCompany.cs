using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    internal class YCompany : Company
    {
        public YCompany(ITransfer transfer) : base(transfer)
        {
        }

        public override void StartTransport()
        {
            Console.WriteLine("Xachmazdan eshyalar YCOmpany vasitesile gonderildi");
            _transfer.TransferFurniture(this);  
        }
    }
}

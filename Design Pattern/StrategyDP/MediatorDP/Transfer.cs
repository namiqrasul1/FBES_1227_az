using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    internal class Transfer : ITransfer
    {
        XCompany xCompany;
        YCompany yCompany;
        ZCompany zCompany;


        public XCompany XCompany { set => xCompany = value; }
        public YCompany YCompany { set => yCompany = value; }
        public ZCompany ZCompany { set => zCompany = value; }


        public void TransferFurniture(Company company)
        {
            if (company is XCompany)
            {
                Console.WriteLine("Eshyalar Xachmazda tekrar dasinmaq uzere masindan dusuyrldu");
                yCompany.StartTransport();
            }
            else if (company is YCompany)
            {
                Console.WriteLine("Eshyalar Gubada tekrar dasinmaq uzere masindan dusuyrldu");
                zCompany.StartTransport();
            }
            else
            {
                Console.WriteLine("Eshyalar Qusara catdrildi");
            }
        }
    }
}

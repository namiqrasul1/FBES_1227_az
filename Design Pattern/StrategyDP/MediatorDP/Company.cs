using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    internal abstract class Company
    {
        protected ITransfer _transfer;
        protected Company(ITransfer transfer)
        {
            _transfer = transfer;
        }
        public abstract void StartTransport();
    }
}

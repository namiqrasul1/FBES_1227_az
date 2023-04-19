using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorHuseyn
{
    public interface IAirport
    {
        void Register(Airplane airplane);

        bool GiveLandingPermission(string FlightNumber);
    }
}

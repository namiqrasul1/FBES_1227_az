using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorHuseyn
{
    public class NorwayAirlines : Airplane
    {
        public override void GetLandingPermission()
        {
            Console.WriteLine(FlightNumber + " No Teyyare enish ucun icaze isteyi gonderdi");
            base.GetLandingPermission();
        }
    }
}

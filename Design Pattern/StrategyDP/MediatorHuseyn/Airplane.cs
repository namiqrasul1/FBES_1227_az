using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorHuseyn
{
    public abstract class Airplane
    {
        public string FlightNumber { get; set; }
        public IAirport Airport { get; set; }


        public virtual void GetLandingPermission()
        {
          bool hasPermission=  Airport.GiveLandingPermission(FlightNumber);


            if (hasPermission)
            {
                Console.WriteLine("Enishe icaze verildi\n");
            }
            else
            {
                Console.WriteLine("Teyyare qeydiyyatdan kecmeyib\nEnishe icaxe verlimedi");
            }
        }
    }
}

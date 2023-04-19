using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorHuseyn
{
    public class HaydarAliyevAirport : IAirport
    {
        public List<Airplane> airplanes { get; set; } = new();

        public bool GiveLandingPermission(string FlightNumber)
        {
            foreach (var item in airplanes)
            {
                if (item.FlightNumber == FlightNumber)
                {
                    return true;
                }
            }
            return false;
        }

        public void Register(Airplane airplane)
        {
            foreach (var item in airplanes)
            {
                if (airplane.FlightNumber == item.FlightNumber)
                {
                    airplane.Airport = this;
                }
            }
            airplane.Airport = this;
            airplanes.Add(airplane);
        }
    }
}

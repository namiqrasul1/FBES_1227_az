using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    internal class StandartDelivery : IShippingStrategy
    {
        public double CalculateCost(double cost)
        {
            return cost * 0.05;
        }

        public string GetDeliveryTime()
        {
            return "3-5 day";
        }
    }
}

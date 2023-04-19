using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    internal class SameDayDelivery : IShippingStrategy
    {
        public double CalculateCost(double cost)
        {
            return cost * 0.15;
        }

        public string GetDeliveryTime()
        {
            return "same day";
        }
    }
}

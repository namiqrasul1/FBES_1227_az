using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    internal class ExpressDelivery : IShippingStrategy
    {
        public double CalculateCost(double cost)
        {
            return cost*0.1;
        }

        public string GetDeliveryTime()
        {
            return "2-3 day";
        }
    }
}

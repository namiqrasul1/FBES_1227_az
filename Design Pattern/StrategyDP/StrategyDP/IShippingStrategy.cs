using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    internal interface IShippingStrategy
    {
        double CalculateCost(double cost);

        string GetDeliveryTime();
    }
}

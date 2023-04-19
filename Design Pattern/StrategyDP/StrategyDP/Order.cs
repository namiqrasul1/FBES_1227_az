using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    internal class Order
    {
        public double OrderTotal { get; set; }

        public IShippingStrategy? ShippingStrategy { get; set; }

        public Order() { }
        
        public void SetStrategy(IShippingStrategy? shippingStrategy)
        {
            ShippingStrategy = shippingStrategy;
        }

        public double CalculateCost()
        {
            return ShippingStrategy!.CalculateCost(OrderTotal);
        }

        public string GetDeliveryTime()
        {
            return ShippingStrategy!.GetDeliveryTime();
        }

    }
}

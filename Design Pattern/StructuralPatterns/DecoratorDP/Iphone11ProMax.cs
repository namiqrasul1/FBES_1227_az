using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    public class Iphone11ProMax : PhoneDecorator
    {
        public Iphone11ProMax(Phone basicPhone) : base(basicPhone)
        {
            base.basicPhone = basicPhone;
        }
        public override int GetCameraCount()
        {
            return base.GetCameraCount();
        }
        public override string GetName()
        {
            return base.GetName() + "11 Pro MAx";
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 500;
        }
    }
}

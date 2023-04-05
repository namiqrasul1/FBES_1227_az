using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    public class Iphonbe11 : PhoneDecorator
    {
        public Iphonbe11(Phone basicPhone) : base(basicPhone)
        {
            base.basicPhone = basicPhone;
        }
        public override int GetCameraCount()
        {
            return base.GetCameraCount();
        }
        public override string GetName()
        {
            return base.GetName() + "11";
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 300;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    public class PhoneDecorator : Phone

    {
        protected Phone basicPhone;
        public PhoneDecorator(Phone basicPhone)
        {
            this.basicPhone = basicPhone;
        }

        public virtual int GetCameraCount()
        {
            return basicPhone.GetCameraCount();
        }

        public virtual string GetName()
        {
            return basicPhone.GetName();
        }

        public virtual double GetPrice()
        {
            return basicPhone.GetPrice();
        }
    }
}

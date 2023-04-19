using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal class ProxyPayment : IPayment
    {
        private Payment? payment;
        private string? paymentApiKey;

        public ProxyPayment(string? paymentApiKey)
        {
            this.paymentApiKey = paymentApiKey;
        }


        public bool Pay(decimal amount)
        {
            if (string.IsNullOrWhiteSpace(paymentApiKey))
            {
                Console.WriteLine("Payment Api key is invalid");
                return false;   
            }

            if (!IsPaymentApiAviable())
            {
                Console.WriteLine("could not connect to payment Api.");
                return false;
            }
            

            Payment payment = new Payment();
            bool result = payment.Pay(amount);

            if (result)
            {
                Console.WriteLine("Payment made successfully");
            }

            return result;
        }

        private bool IsPaymentApiAviable()
        {
            Console.WriteLine("Connecting to Api Key...");
            return true;
        }
    }
}

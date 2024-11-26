using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.Encapsulate.Ex02.PaymentStrategy
{
    public class PaypalService : IPaymentService
    {
        public void PaymentService()
         => Console.WriteLine("Paying Using Paypal..Processing");
    }
}
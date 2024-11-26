using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.Encapsulate.Ex02.PaymentStrategy
{
    public class BankTransferService : IPaymentService
    {
        public void PaymentService()
        => Console.WriteLine("Paying Using BankTransfer..Processing");
    }
}
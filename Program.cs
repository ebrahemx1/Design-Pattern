using Design.Encapsulate.Ex02;
using Design.Encapsulate.Ex02.PaymentStrategy;

#region Encapsulate What Varies 

#region  Ex01
// StandardPricing standard = new StandardPricing();

// DisscountPricing dis = new DisscountPricing(){DisscountAmount = 30};

// Product p = new Product()
// {
//     BasePrice =100,
// };
// var result = p.CalculateProductPrice(dis);
// Console.WriteLine(result);
#endregion

#region Ex02
PaymentGetWay payment = new PaymentGetWay();
payment.PrcoessPayment(new PaypalService());
payment.PrcoessPayment(new CreditCardService());
payment.PrcoessPayment(new BankTransferService());
#endregion

#endregion


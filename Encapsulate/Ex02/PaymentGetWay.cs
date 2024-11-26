namespace Design.Encapsulate.Ex02
{
    public class PaymentGetWay
    {
        public string Name { get; set; }
   
        public void PrcoessPayment(IPaymentService service)
        {
            service.PaymentService();
        }
    }
}
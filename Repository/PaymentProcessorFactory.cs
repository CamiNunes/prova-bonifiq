namespace ProvaPub.Repository
{
    public class PaymentProcessorFactory
    {
        public PaymentProcessor CreatePaymentProcessor(string paymentMethod)
        {
            switch (paymentMethod)
            {
                case "pix":
                    return new PixPaymentProcessor();
                case "creditcard":
                    return new CreditCardPaymentProcessor();
                case "paypal":
                    return new PayPalPaymentProcessor();
                default:
                    throw new ArgumentException("Método de pagamento não suportado", nameof(paymentMethod));
            }
        }
    }
}

using ProvaPub.Models;

namespace ProvaPub.Repository
{
    public class CreditCardPaymentProcessor : PaymentProcessor
    {
        public override async Task<bool> PayOrder(decimal paymentValue, int customerId)
        {
            return true;
        }
    }
}
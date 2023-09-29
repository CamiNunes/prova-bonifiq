using ProvaPub.Models;

namespace ProvaPub.Repository
{
    public abstract class PaymentProcessor
    {
        public abstract Task<bool> PayOrder(decimal paymentValue, int customerId);
    }
}
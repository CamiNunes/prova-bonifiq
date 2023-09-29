using ProvaPub.Models;
using System.Reflection.Metadata.Ecma335;

namespace ProvaPub.Repository
{
    public class PixPaymentProcessor : PaymentProcessor
    {
        public override async Task<bool> PayOrder(decimal paymentValue, int customerId)
        {
            return true;
        }
    }
}

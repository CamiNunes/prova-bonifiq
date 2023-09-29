using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
	public class OrderService
	{
		private readonly PaymentProcessorFactory paymentProcessorFactory;

        public OrderService(PaymentProcessorFactory paymentProcessorFactory)
        {
            this.paymentProcessorFactory = paymentProcessorFactory;
        }

        public async Task<bool> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
        {
            var paymentProcessor = paymentProcessorFactory.CreatePaymentProcessor(paymentMethod);
            return await paymentProcessor.PayOrder(paymentValue, customerId);
        }
	}
}

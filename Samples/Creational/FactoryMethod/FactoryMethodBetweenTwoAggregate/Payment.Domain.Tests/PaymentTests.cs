using System;
using Xunit;

namespace Payment.Domain.Tests
{
    public class PaymentTests
    {
        [Fact]
        public void Constructor_probably_assign_properties_correctly()
        {
            var orderId = 1;
            var orderValue = 1000;
            var order = new Order(orderId, DateTime.Now.AddMinutes(15));

            var payment = order.Payed(orderValue);

           Assert.Equal(payment.OrderId, orderId);
           Assert.Equal(payment.Value, orderValue);
        }

        [Fact]
        public void Constructor_probably_throw_exception_when_order_invalid()
        {
            var orderId = 1;
            var orderValue = 1000;
            var order = new Order(orderId, DateTime.Now.AddMinutes(-1));

            var action = new Action(() => order.Payed(orderValue));

            Assert.Throws<Exception>(action);
        }
    }
}

using FluentAssertions;
using MyOrder.OrderStatePattern;
using Xunit;

namespace MyOrder.Tests.Unit
{
    public class CustomOrderTests
    {
        [Fact]
        public void Constructor_assign_properties()
        {
            var orderId = 1;
            var customerId = 2;
            var amount = 3;
            var order = new CustomOrder(orderId,customerId,amount);

            order.Id.Should().Be(orderId);
            order.CustomerId.Should().Be(customerId);
            order.Amount.Should().Be(amount);
            order.State.Should().BeOfType<DraftState>();
        }
    }
}

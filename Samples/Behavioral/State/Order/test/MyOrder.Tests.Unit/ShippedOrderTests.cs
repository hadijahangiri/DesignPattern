using System;
using FluentAssertions;
using MyOrder.OrderStatePattern;
using Xunit;

namespace MyOrder.Tests.Unit
{
    public class ShippedOrderTests
    {
        private readonly CustomOrder _order;

        public ShippedOrderTests()
        {
            _order = new CustomOrder(1, 1, 1);
        }

        [Fact]
        public void when_state_is_draft_change_state_throw_exception()
        {
            Action sut = () => _order.Shipped();

            sut.Should().Throw<Exception>();
        }

        [Fact]
        public void when_state_is_confirm_change_state_to_shipped()
        {
            _order.Confirm();

            _order.Shipped();

            _order.State.Should().BeOfType<ShippedState>();
        }

        [Fact]
        public void when_state_is_cancel_throw_exception()
        {
            _order.Cancel();

            Action sut = () => _order.Shipped();

            sut.Should().Throw<Exception>();
        }


        [Fact]
        public void when_state_is_shipped_throw_exception()
        {
            _order.Confirm();
            _order.Shipped();

            Action sut = () => _order.Shipped();

            sut.Should().Throw<Exception>();
        }

    }
}
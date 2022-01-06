using System;
using FluentAssertions;
using MyOrder.OrderStatePattern;
using Xunit;

namespace MyOrder.Tests.Unit
{
    public class CancelOrderTests
    {
        private readonly CustomOrder _order;

        public CancelOrderTests()
        {
            _order = new CustomOrder(1, 1, 1);
        }

        [Fact]
        public void when_state_is_draft_change_state_to_cancel()
        {
            _order.Cancel();

            _order.State.Should().BeOfType<CancelState>();
        }

        [Fact]
        public void when_state_is_confirm_change_state_to_cancel()
        {
            _order.Confirm();

            _order.Cancel();

            _order.State.Should().BeOfType<CancelState>();
        }

        [Fact]
        public void when_state_is_cancel_throw_exception()
        {
            _order.Cancel();

            Action sut = () => _order.Cancel();

            sut.Should().Throw<Exception>();
        }


        [Fact]
        public void when_state_is_shipped_throw_exception()
        {
            _order.Confirm();
            _order.Shipped();

            Action sut = () => _order.Cancel();

            sut.Should().Throw<Exception>();
        }

    }
}
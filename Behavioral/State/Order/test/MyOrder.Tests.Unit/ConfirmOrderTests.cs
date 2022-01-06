using System;
using System.Collections.Generic;
using FluentAssertions;
using MyOrder.OrderStatePattern;
using Xunit;

namespace MyOrder.Tests.Unit
{
    public class ConfirmOrderTests
    {
        private readonly CustomOrder _order;

        public ConfirmOrderTests()
        {
            _order = new CustomOrder(1, 1, 1);
        }

        [Fact]
        public void when_state_is_draft_change_state_to_confirm()
        {
            _order.Confirm();

            _order.State.Should().BeOfType<ConfirmState>();
        }

       
        [Fact]
        public void when_state_is_cancel_throw_exception()
        {
            _order.Cancel();

            Action sut = () => _order.Confirm();

            sut.Should().Throw<Exception>();
        }

        [Fact]
        public void when_state_is_confirm_throw_exception()
        {
            _order.Confirm();

            Action sut = () => _order.Confirm();

            sut.Should().Throw<Exception>();
        }

        [Fact]
        public void when_state_is_shipped_throw_exception()
        {
            _order.Confirm();
            _order.Shipped();

            Action sut = () => _order.Confirm();

            sut.Should().Throw<Exception>();
        }
    }

}
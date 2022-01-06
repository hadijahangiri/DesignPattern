using System;
using MyOrder.OrderStatePattern;

namespace MyOrder
{
    public class CustomOrder
    {
        public long Id { get; private set; }
        public long CustomerId { get; private set; }
        public int Amount { get; private set; }
        public OrderState State { get; private set; }

        public CustomOrder(long id, long customerId, int amount)
        {
            Id = id;
            CustomerId = customerId;
            Amount = amount;
            State = new DraftState();
        }

        public void Confirm() => State = State.Confirm();

        public void Cancel() => State = State.Cancel();

        public void Shipped() => State = State.Shipped();
    }
}

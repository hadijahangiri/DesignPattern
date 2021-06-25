using System;

namespace Payment.Domain
{
    public class Payment
    {
        public int Id { get; private set; }
        public int Value { get; private set; }
        public int OrderId { get; private set; }

        internal Payment(int value, int orderId)
        {
            Id = 0;
            Value = value;
            OrderId = orderId;
        }
    }
}

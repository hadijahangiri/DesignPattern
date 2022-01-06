using System;

namespace MyOrder.OrderStatePattern
{
    public abstract class OrderState
    {
        public virtual OrderState Confirm()
        {
            throw new Exception("");
        }

        public virtual OrderState Cancel()
        {
            throw new Exception("");
        }

        public virtual OrderState Shipped()
        {
            throw new Exception("");
        }
    }
}
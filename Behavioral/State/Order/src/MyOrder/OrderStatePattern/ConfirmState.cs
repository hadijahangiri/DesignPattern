namespace MyOrder.OrderStatePattern
{
    public class ConfirmState : OrderState
    {
        public override OrderState Cancel()
        {
            return new CancelState();
        }

        public override OrderState Shipped()
        {
            return new ShippedState();
        }
    }
}
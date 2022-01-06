namespace MyOrder.OrderStatePattern
{
    public class DraftState : OrderState
    {
        public override OrderState Confirm()
        {
            return new ConfirmState();
        }

        public override OrderState Cancel()
        {
            return new CancelState();
        }
    }
}
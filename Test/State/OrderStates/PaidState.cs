namespace Lessons.State.OrderStates;

public class PaidState : OrderState
{
    public override void Handle(OrderContext orderContext)
    {
        //вызываем API  банка для оплаты

        orderContext.OrderState = new ShippedState();
        orderContext.Handle();
    }
}

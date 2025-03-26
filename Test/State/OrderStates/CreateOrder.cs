namespace Lessons.State.OrderStates;

public class CreateOrder : OrderState
{
    public override void Handle(OrderContext orderContext)
    {
        //...
        orderContext.OrderState = new PaidState();
        orderContext.Handle();
    }
}

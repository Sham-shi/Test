namespace Lessons.State.OrderStates;

public abstract class OrderState
{
    public abstract void Handle(OrderContext orderContext);
}

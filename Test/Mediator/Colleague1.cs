namespace Lessons.Mediator;

public class Colleague1 : Colleague
{
    private MyMediator _mediator;
    public Colleague1(MyMediator mediator) : base(mediator)
    {
        _mediator = mediator;
    }

    public void Send(string message)
    {
        _mediator.Send(message, this);
    }

    public void Notify(string message)
    {

    }
}

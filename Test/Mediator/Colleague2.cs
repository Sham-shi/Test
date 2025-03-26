
namespace Lessons.Mediator;

public class Colleague2 : Colleague
{
    private MyMediator _mediator;
    public Colleague2(MyMediator mediator) : base(mediator)
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

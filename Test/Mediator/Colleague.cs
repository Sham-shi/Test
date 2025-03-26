
namespace Lessons.Mediator;

public abstract class Colleague
{
    protected MyMediator _mediator;

    public Colleague(MyMediator mediator)
    {
        _mediator = mediator;
    }

    public void Notify(string message)
    {

    }
}

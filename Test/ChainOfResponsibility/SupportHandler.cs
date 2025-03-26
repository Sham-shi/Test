
namespace Lessons.ChainOfResponsibility;

public abstract class SupportHandler : ISupportHandler
{
    protected ISupportHandler _nextHandler;
    public abstract void HandlerRequest(SupportRequest supportRequest);

    public ISupportHandler SetNextHandler(ISupportHandler nextHandler)
    {
        _nextHandler = nextHandler;

        return nextHandler;
    }
}

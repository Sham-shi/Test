
namespace Lessons.ChainOfResponsibility;

public interface ISupportHandler
{
    public void HandlerRequest(SupportRequest supportRequest);
    ISupportHandler SetNextHandler(ISupportHandler nextHandler);
}

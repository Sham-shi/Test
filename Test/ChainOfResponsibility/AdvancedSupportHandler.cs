
namespace Lessons.ChainOfResponsibility;

public class AdvancedSupportHandler : SupportHandler
{
    public override void HandlerRequest(SupportRequest supportRequest)
    {
        if (supportRequest.Complexity <= 4)
        {
            Console.WriteLine("Можем обработать");
        }
        else
        {
            _nextHandler.HandlerRequest(supportRequest);
        }
    }
}

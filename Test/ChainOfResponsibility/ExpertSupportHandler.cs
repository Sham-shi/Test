
namespace Lessons.ChainOfResponsibility;

public class ExpertSupportHandler : SupportHandler
{
    public override void HandlerRequest(SupportRequest supportRequest)
    {
        if (supportRequest.Complexity <= 6)
        {
            Console.WriteLine("Можем обработать");
        }
        else
        {
            Console.WriteLine("Мы не можем обработать");
        }
    }
}

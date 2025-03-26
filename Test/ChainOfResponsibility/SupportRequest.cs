
namespace Lessons.ChainOfResponsibility;

public class SupportRequest
{
    public int Complexity { get; set; }

    public SupportRequest(int complexity)
    {
        Complexity = complexity;
    }
}

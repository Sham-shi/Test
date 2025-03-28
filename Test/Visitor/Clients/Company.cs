using Lessons.Visitor.Visitors;

namespace Lessons.Visitor.Clients;

public class Company : IClient
{
    public string Title { get; set; }
    public string RegNumber { get; set; }

    public string Accept(IVisitor visitor)
    {
        return visitor.Serialize(this);
    }
}

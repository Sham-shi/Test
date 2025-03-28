using Lessons.Visitor.Visitors;

namespace Lessons.Visitor.Clients;

public interface IClient
{
    public string Accept(IVisitor visitor);
}

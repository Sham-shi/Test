
using Lessons.Visitor.Clients;

namespace Lessons.Visitor.Visitors;

public interface IVisitor
{
    public string Serialize(Company company);
    public string Serialize(Person person);
}

using Lessons.Visitor.Visitors;

namespace Lessons.Visitor.Clients;

public class Person : IClient
{
    public string FIO {  get; set; }
    public string AccNumber { get; set; }

    public string Accept(IVisitor visitor)
    {
        return visitor.Serialize(this);
    }
}

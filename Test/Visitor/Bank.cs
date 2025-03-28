
using Lessons.Visitor.Clients;
using Lessons.Visitor.Visitors;

namespace Lessons.Visitor;

public class Bank
{
    private List<IClient> clients;

    public Bank()
    {
        clients = new List<IClient>();
    }

    public void Add(IClient client)
    {
        clients.Add(client);
    }

    public void Remove(IClient client)
    {
        clients.Remove(client);
    }

    public void SaveDataBase(IVisitor visitor)
    {
        for (int i = 0; i < clients.Count; i++)
        {
            var serializeClient = clients[i].Accept(visitor);
            //...запись в бд
        }
    }
}

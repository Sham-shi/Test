
namespace Lessons.Iterator;

public class ConcreteAggregate<T> : IAggregate<T>
{
    private List<T> _list;

    public ConcreteAggregate()
    {
        _list = new List<T>();
    }

    public void AddItem(T item)
    {
        _list.Add(item);
    }

    public IIterator<T> CreateIterator()
    {
        return new ConcreteIterator<T>(_list);
    }
}

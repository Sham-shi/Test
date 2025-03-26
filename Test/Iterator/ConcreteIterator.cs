
namespace Lessons.Iterator;

public class ConcreteIterator<T> : IIterator<T>
{
    private List<T> _collection;
    private int currentIndex = 0;
    public ConcreteIterator(List<T> collection)
    {
        _collection = collection;
    }
    public bool HasNext()
    {
        return currentIndex < _collection.Count;
    }

    public T Next()
    {
        if(HasNext())
        {
            return _collection[currentIndex++];
        }

        throw new Exception();
    }
}

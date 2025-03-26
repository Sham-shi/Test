
namespace Lessons.Iterator;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}

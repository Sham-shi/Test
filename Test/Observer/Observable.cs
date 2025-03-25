
namespace Lessons.Observer;

public class Observable : IObservable
{
    public string Name {  get; set; }

    private List<IObserver> _observers;

    public Observable()
    {
        _observers = new List<IObserver>();
    }
    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObserver()
    {
        for (int i = 0; i < _observers.Count; i++)
        {
            _observers[i].Update(Name);
        }
    }
}


using System;

namespace Lessons.Observer;

public interface IObservable
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObserver();
}

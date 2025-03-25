
using Lessons.Observer;

var observer1 = new Observer("observer1");
var observer2 = new Observer("observer2");
var observer3 = new Observer("observer3");

var observable = new Observable();

observable.AddObserver(observer1);
observable.AddObserver(observer2);
observable.AddObserver(observer3);

observable.Name = "Not Empty";

observable.NotifyObserver();
observable.RemoveObserver(observer3);

observable.Name = "Some Name";

observable.NotifyObserver();
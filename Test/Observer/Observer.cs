
namespace Lessons.Observer;

public class Observer : IObserver
{
    private string _nameObject;
    public Observer(string nameObject)
    {
        _nameObject = nameObject;
    }
    public void Update(string name)
    {
        Console.WriteLine(_nameObject + " " + name);
    }
}

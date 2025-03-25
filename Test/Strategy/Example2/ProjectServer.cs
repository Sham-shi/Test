
namespace Lessons.Strategy.Example2;

public class ProjectServer : IProjectFile
{
    public void Save(string project)
    {
        Console.WriteLine("Сохранил на сервер.");
    }
}

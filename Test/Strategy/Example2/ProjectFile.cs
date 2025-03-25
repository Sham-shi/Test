
namespace Lessons.Strategy.Example2;

public class ProjectFile : IProjectFile
{
    public void Save(string project)
    {
        Console.WriteLine("Сохранил в файл.");
    }
}

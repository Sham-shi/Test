
namespace Lessons.Strategy.Example2;

public class Context
{
    private IProjectFile _projectFile;
    public Context()
    {
        _projectFile = new ProjectFile();
    }

    public void Execute(string project)
    {
        _projectFile.Save(project);
    }

    public void ChangeProjectSave(IProjectFile projectFile)
    {
        _projectFile = projectFile;
    }
}

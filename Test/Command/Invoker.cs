
namespace Lessons.Command;

public class Invoker
{
    private List<Command> _commands;
    public Invoker(Command command)
    {
        _commands = new List<Command>();
        _commands.Add(command);
        command.Execute();
    }

    public void AddCommand(Command command)
    {
        _commands.Add(command);
        command.Execute();
    }

    public void UndoCommand()
    {
        var command = _commands[_commands.Count - 1];
        command.Undo();
        _commands.Remove(command);
    }
}

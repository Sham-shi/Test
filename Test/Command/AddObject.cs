
namespace Lessons.Command;

public class AddObject : Command
{
    private int _x;
    private int _y;
    private int _z;
    private string _name;

    public AddObject(int x, int y, int z, string name)
    {
        _x = x;
        _y = y;
        _z = z;
        _name=name;
    }
    public override void Execute()
    {
        Console.WriteLine($"Добавил объект " + _name);
    }

    public override void Undo()
    {
        _x = 0;
        _y = 0;
        _z = 0;

        Console.WriteLine($"Удалил объект " + _name);
    }
}

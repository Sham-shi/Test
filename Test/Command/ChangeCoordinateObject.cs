
namespace Lessons.Command;

public class ChangeCoordinateObject : Command
{
    private int _x;
    private int _y;
    private int _z;

    public ChangeCoordinateObject(int x, int y, int z)
    {
        _x = x;
        _y = y;
        _z = z;
    }
    public override void Execute()
    {
        Console.WriteLine($"Установил координаты {_x} {_y} {_z}");
    }

    public override void Undo()
    {
        _x = 0;
        _y = 0;
        _z = 0;

        Console.WriteLine($"Отменил команду смены координат {_x} {_y} {_z}");
    }
}

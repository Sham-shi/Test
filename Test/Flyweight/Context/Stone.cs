
using Lessons.Flyweight.Model;

namespace Lessons.Flyweight.Context;

public class Stone
{
    private int _x;
    private int _y;

    private StoneModel _stoneModel;

    public Stone(int x, int y, StoneModel stoneModel)
    {
        _x=x;
        _y=y;
        _stoneModel = stoneModel;
    }

    public void Display()
    {
        _stoneModel.Render(_x, _y);
    }
}

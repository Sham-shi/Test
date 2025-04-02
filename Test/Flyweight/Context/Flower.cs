
using Lessons.Flyweight.Model;

namespace Lessons.Flyweight.Context;

public class Flower
{
    private int _x;
    private int _y;

    private FlowerModel _flowerModel;

    public Flower(int x, int y, FlowerModel flowerModel)
    {
        _x=x;
        _y=y;
        _flowerModel=flowerModel;
    }

    public void Display()
    {
        _flowerModel.Render(_x, _y);
    }
}

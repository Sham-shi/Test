
namespace Lessons.Flyweight.Model;

public class FlowerModel
{
    private List<Point> _points;

    public FlowerModel(List<Point> points)
    {
        _points = points;
    }

    public void Render(int x,  int y)
    {

    }
}

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}
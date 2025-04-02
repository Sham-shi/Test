
using Lessons.Flyweight.Context;
using Lessons.Flyweight.Model;

namespace Lessons.Flyweight;

public class FlyweightFactory
{
    private Dictionary<List<Point>, FlowerModel> flowersModel = new Dictionary<List<Point>, FlowerModel>();
    private Dictionary<List<Point>, StoneModel> stonesModel = new Dictionary<List<Point>, StoneModel>();

    public FlowerModel GetFlowerModel(List<Point> points)
    {
        if (!flowersModel.ContainsKey(points))
        {
            flowersModel[points] = new FlowerModel(points);
        }

        return flowersModel[points];
    }

    public void RemoveFlowerModel(List<Point> points)
    {
        flowersModel.Remove(points);
    }

    public StoneModel GetStoneModel(List<Point> points)
    {
        if (!stonesModel.ContainsKey(points))
        {
            stonesModel[points] = new StoneModel(points);
        }

        return stonesModel[points];
    }

    public void RemoveStoneModel(List<Point> points)
    {
        stonesModel.Remove(points);
    }
}

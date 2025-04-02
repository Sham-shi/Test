using Lessons.Flyweight;
using Lessons.Flyweight.Context;
using Lessons.Flyweight.Model;

var flowers = new List<Flower>();

var flyweightFactory = new FlyweightFactory();

var list = new List<Point>();

list.Add(new Point(1,1));

var flowerModel = flyweightFactory.GetFlowerModel(list);

var flower = new Flower(1, 10, flowerModel);
flower.Display();

flowers.Add(flower);

var flowerModel1 = flyweightFactory.GetFlowerModel(list);

var flower1 = new Flower(2, 10, flowerModel1);
flower.Display();

flowers.Add(flower1);

flowers.RemoveAt(0);
flowers.RemoveAt(1);
flyweightFactory.RemoveFlowerModel(list);
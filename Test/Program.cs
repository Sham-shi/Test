using Lessons.Iterator;

var concreteAggregate = new ConcreteAggregate<int>();

concreteAggregate.AddItem(1);
concreteAggregate.AddItem(2);
concreteAggregate.AddItem(3);
concreteAggregate.AddItem(4);
concreteAggregate.AddItem(5);

var iterator = concreteAggregate.CreateIterator();

while(iterator.HasNext())
{
    var item = iterator.Next();
    Console.WriteLine(item);
}
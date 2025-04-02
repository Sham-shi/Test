using Lessons.Singleton;

var singleton = Singleton.GetInstance();

var singleton1 = Singleton.GetInstance();

Console.WriteLine(singleton.GetHashCode());
Console.WriteLine(singleton1.GetHashCode());
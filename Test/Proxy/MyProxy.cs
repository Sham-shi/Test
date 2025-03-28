
namespace Lessons.Proxy;

public class MyProxy : Subject
{
    private RealSubject realSubject;

    public MyProxy()
    {
        realSubject = new RealSubject();
    }

    public override void SomeAction()
    {
        //...
        //...
        //логирование
        //валидация
        realSubject.SomeAction();
    }
}

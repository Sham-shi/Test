
using Lessons.Facade.SubSystem;

namespace Lessons.Facade;

public class Facade
{
    SubSystemA _subSystemA;
    SubSystemB _subSystemB;
    SubSystemC _subSystemC;
    public Facade(SubSystemA subSystemA,  SubSystemB subSystemB, SubSystemC subSystemC)
    {
        _subSystemA = subSystemA;
        _subSystemB = subSystemB;
        _subSystemC = subSystemC;
    }

    public void Operation1()
    {
        _subSystemA.OperationA();
        _subSystemB.OperationB();
        _subSystemC.OperationC();
    }

    public void Operation2()
    {
        _subSystemC.OperationC();
        _subSystemB.OperationB();
        _subSystemA.OperationA();
    }

    public void Operation3()
    {
        _subSystemC.OperationC();
        _subSystemA.OperationA();
        _subSystemB.OperationB();
    }
}

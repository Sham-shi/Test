using Lessons.Facade;
using Lessons.Facade.SubSystem;

var subSystemA = new SubSystemA();
var subSystemB = new SubSystemB();
var subSystemC = new SubSystemC();

var facade = new Facade(subSystemA, subSystemB, subSystemC);

facade.Operation1();
facade.Operation2();
facade.Operation3();
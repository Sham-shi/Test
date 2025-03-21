using Lessons.FactoryMethod;

var factoryMilk = new FactoryMilk();
var factoryApple = new FactoryApple();

var milk = factoryMilk.CreateProduct();
var apple = factoryApple.CreateProduct();




using Lessons.Command;

var addObject = new AddObject(1, 1, 1, "rock");
var invoker = new Invoker(addObject);
var changeCoordinateObject = new ChangeCoordinateObject(1, 2, 3);
invoker.AddCommand(changeCoordinateObject);
invoker.UndoCommand();
invoker.UndoCommand();
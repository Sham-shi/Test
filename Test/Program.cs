
using Lessons.Strategy.Example2;

var projectFile = new ProjectFile();
var projectServer = new ProjectServer();

var context = new Context();
context.Execute("");

context.ChangeProjectSave(projectServer);
context.Execute("");
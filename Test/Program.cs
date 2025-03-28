using Lessons.Decorator;


var serverApi = new ServerApi();
var validationReqest = new ValidationReqest(serverApi, "arg1", "arg2");

validationReqest.Get();
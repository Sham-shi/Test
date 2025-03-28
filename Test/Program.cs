using Lessons.Visitor;
using Lessons.Visitor.Clients;
using Lessons.Visitor.Visitors;

var bank = new Bank();
var person = new Person();
person.FIO = "Petrov Petr";
person.AccNumber = "1122";

var company = new Company();
company.Title = "AAA Company";
company.RegNumber = "3344";

bank.Add(person);
bank.Add(company);

var HTMLVisitor = new HTMLVisitor();
bank.SaveDataBase(HTMLVisitor);
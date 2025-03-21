
using Lessons.Builder;

var documentBuilder = new DocumentBuilder();
var director = new Director(documentBuilder);
var document = director.Create();

//паттерн прототип
var document1 = document.Clone();


//копирование с помощью сериализации
var documentBuilder1 = documentBuilder.Copy();
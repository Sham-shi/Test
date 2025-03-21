
using Lessons.Builder;

var documentBuilder = new DocumentBuilder();

var document = documentBuilder
                .SetTitle("title")
                .SetBody("bode")
                .SetFooter("footer")
                .Build();

//Fluent
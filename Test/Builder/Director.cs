using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Builder
{
    public class Director
    {
        private IDocumentBuilder _documentBuilder;

        public Director(IDocumentBuilder documentBuilder)
        {
            _documentBuilder = documentBuilder;
        }
        public Document Create()
        {
            var document = _documentBuilder
                            .SetTitle("title")
                            .SetBody("bode")
                            .SetFooter("footer")
                            .Build();

            return document;
        }
    }
}

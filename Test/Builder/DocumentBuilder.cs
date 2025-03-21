using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Builder
{
    public class DocumentBuilder : IDocumentBuilder
    {
        private Document document;

        public DocumentBuilder()
        {
            document = new Document();
        }

        public IDocumentBuilder SetBody(string body)
        {
            document.Body = body;

            return this;
        }

        public IDocumentBuilder SetFooter(string footer)
        {
            document.Footer = footer;

            return this;
        }

        public IDocumentBuilder SetTitle(string title)
        {
            document.Title = title;

            return this;
        }
        public Document Build()
        {
            return document;
        }
    }
}

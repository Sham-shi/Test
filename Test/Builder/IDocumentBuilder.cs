using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Builder
{
    public interface IDocumentBuilder
    {
        IDocumentBuilder SetTitle(string title);
        IDocumentBuilder SetBody(string body);
        IDocumentBuilder SetFooter(string footer);
        Document Build();
    }
}

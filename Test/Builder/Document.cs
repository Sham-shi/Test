using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lessons.Builder
{
    public class Document
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }


        //паттерн Прототип (Prototype)
        public Document Clone()
        {
            return new Document()
            {
                Title = this.Title,
                Body = this.Body,
                Footer = this.Footer,
            };
        }
    }
}

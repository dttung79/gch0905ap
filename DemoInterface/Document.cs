using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class Document : IPrintable
    {
        public string Content { get; set; }
        public Document()
        {
            Content = "Document";
        }
        public Document(string content)
        {
            Content = content;
        }
        public void Print()
        {
            Console.WriteLine(Content);
        }
    }
}
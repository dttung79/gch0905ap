using System;
using System.Collections.Generic;
namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPrintable> printables = new List<IPrintable>();

            printables.Add(new Line("Line", 10));
            printables.Add(new Line("Line", 20));
            printables.Add(new Square("Square", 5));
            printables.Add(new Document("Hello Interface"));

            foreach (IPrintable p in printables)
            {
                p.Print();
            }
        }
    }
}

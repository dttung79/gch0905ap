using System;

namespace DemoSingleton
{
    public class Printer
    {
        private static Printer spooler;
        private int pages;
        private Printer()
        {
            pages = 500;
        }
        public static Printer GetSpooler()
        {
            if (spooler == null) 
            {
                System.Console.WriteLine("Connecting to a printer...");
                spooler = new Printer();
            }
            System.Console.WriteLine("Printer connected.");
            return spooler;
        }

        public void AddPages(int pages)
        {
            this.pages += pages;
        }

        public void Print(Document doc)
        {
            System.Console.WriteLine("Printing document: {0} ...", doc.Title);
            System.Console.WriteLine("Number of pages to print: {0}", doc.Pages);
            if (pages < doc.Pages)
            {
                doc.Pages -= pages;
                pages = 0;
                System.Console.WriteLine("Not enough pages. Add more pages.");
            }
            else
            {
                pages -= doc.Pages;
            }
            System.Console.WriteLine("Done!");
            System.Console.WriteLine("Pages left: {0}", pages);
        }
    }
}
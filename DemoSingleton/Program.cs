using System;

namespace DemoSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 3 computers named HP, Macbook, Server
            Computer hp = new Computer("HP");
            Computer macbook = new Computer("Macbook");
            Computer server = new Computer("Server");

            // create 3 documents:
            // 1. Assignment1.docx 30 pages
            Document doc1 = new Document("Assignment1.docx", 30);
            // 2. Presentation.pptx 45 pages
            Document doc2 = new Document("Presentation.pptx", 45);
            // 3. MyNovel.docx 618 pages
            Document doc3 = new Document("MyNovel.docx", 618);

            // print the documents on the computers
            hp.Print(doc1);
            System.Console.WriteLine("------------------------");
            macbook.Print(doc2);
            System.Console.WriteLine("------------------------");
            server.Print(doc3);
            System.Console.WriteLine("------------------------");

            // enter new pages
            System.Console.WriteLine("Enter number of pages to add: ");
            int pages = int.Parse(System.Console.ReadLine());
            Printer spooler = Printer.GetSpooler();
            spooler.AddPages(pages);

            server.Print(doc3);
        }
    }
}

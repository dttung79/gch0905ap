using System;

namespace DemoSingleton
{
    public class Document
    {
        public int Pages { get; set; }
        public string Title { get; set; }
        public Document(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }
                
    }
}
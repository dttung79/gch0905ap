using System;

namespace ProductProgram
{
    public class Product
    {
        private string name; // attribute
        private int price; // attribute

        public string Name
        {
            get { return name; }
            set 
            {
                if (value == "") System.Console.WriteLine("Invalid product name!");
                else name = value;
            }
        }

        public int Price 
        {
            get { return price; }
            set 
            {
                if (value <= 0) System.Console.WriteLine("Invalid product price!");
                else price = value;
            }
        }
        // default constructor
        public Product()
        {
            name = "Product 001";
            price = 100;
        }
        // parameter constructor
        public Product(string name, int price)
        {
            Name = name;    // this.name = name;
            Price = price;  // this.price = price;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Product: " + name);
            System.Console.WriteLine("Price: " + price);
        }
    }
}
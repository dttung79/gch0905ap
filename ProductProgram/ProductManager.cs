using System;
using System.Collections.Generic;

namespace ProductProgram
{
    public class ProductManager
    {
        private List<Product> listProducts;

        public ProductManager()
        {
            listProducts = new List<Product>();
        }

        public void AddNewProduct()
        {
            // ask user to enter name & price
            System.Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter product price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            // create a new product with name & price using parameter constructor
            Product p = new Product(name, price);

            // add to list products
            listProducts.Add(p);
        }

        public void EditProduct()
        {
            // find product by name
            System.Console.Write("Enter product name to search: ");
            string name = Console.ReadLine();
            Product p = FindProduct(name);
            if (p == null)
            {
                System.Console.WriteLine("Product not found!");
            }
            else 
            {
                // enter new price
                System.Console.Write("Enter new price: ");
                int price = Convert.ToInt32(Console.ReadLine());
                // change product price
                p.Price = price;
            }
        }

        public void DeleteProduct()
        {
            // find product p by name
            System.Console.Write("Enter product name to search: ");
            string name = Console.ReadLine();
            Product p = FindProduct(name);
            // delete product by calling Remove and pass p
            listProducts.Remove(p);
        }

        private Product FindProduct(string name)
        {
            for (int i = 0; i < listProducts.Count; i++)
                if (listProducts[i].Name == name) return listProducts[i];

            return null;
        }

        public void ShowProducts()
        {
            // C1: use traditional for loop
            // for (int i = 0; i < listProducts.Count; i++)
            //     listProducts[i].ShowInfo();
            // C2: use foreach loop
            foreach (Product p in listProducts)
                p.ShowInfo();
        }
    }
}
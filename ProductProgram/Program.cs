using System;

namespace ProductProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager();
            while (true)
            {
                // print menu 
                System.Console.WriteLine("Product Manager");
                System.Console.WriteLine("1. Add new product.");
                System.Console.WriteLine("2. Edit product.");
                System.Console.WriteLine("3. Delete product.");
                System.Console.WriteLine("4. Show all products.");

                // ask user to enter a choice
                System.Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                // based on choice, do corresponding task
                switch (choice)
                {
                    case 1: manager.AddNewProduct(); break;
                    case 2: manager.EditProduct(); break;
                    case 3: manager.DeleteProduct(); break;
                    case 4: manager.ShowProducts(); break;
                    case 0: break;
                    default: System.Console.WriteLine("Invalid choice!"); break;
                }
            }
        }
    }
}

using System;

namespace DemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Animal dog = new Animal("Dog", 5);
            // dog.ShowInfo();

            Pet cat = new Pet();
            cat.ShowInfo();

            Pet dog = new Pet("Dog", 4, "John");
            dog.ShowInfo();
        }

    }
}

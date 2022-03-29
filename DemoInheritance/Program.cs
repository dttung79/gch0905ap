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

            cat.Kind = "Cat";
            cat.Age = 10;
            cat.ShowInfo();
        }
    }
}

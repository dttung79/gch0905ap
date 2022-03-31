using System;

namespace PersonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person s = new Person();
            s.ShowInfo();

            s = new Student();
            s.ShowInfo();

            s = new Teacher();
            s.ShowInfo();
        }
    }
}

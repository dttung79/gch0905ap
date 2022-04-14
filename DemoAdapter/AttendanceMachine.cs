using System;


namespace DemoAdapter
{
    public class AttendanceMachine
    {
        public void Swipe()
        {
            Console.WriteLine("Please swipe your card ...");
            Console.ReadLine();
            System.Console.WriteLine("Reading card ...");
            Console.ReadLine();
            System.Console.WriteLine("Card read successfully ...");
            Console.ReadLine();
            System.Console.WriteLine("Welcome employee ... Have a great day!");
        }
    }
}
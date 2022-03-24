using System;

namespace ClassroomManagement 
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom manager = new ClassRoom();
            while(true)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("Classroom Manager");
                System.Console.WriteLine("1. Add Teacher");
                System.Console.WriteLine("2. Add Students");
                System.Console.WriteLine("3. Grade Students");
                System.Console.WriteLine("4. Show Info");
                System.Console.WriteLine("0. EXIT");
                // ask user to enter a choice
                System.Console.Write("Enter you choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                //based on choice, do corresponding task
                switch (choice)
                {
                    case 1: manager.AddTeacher(); break;
                    case 2: manager.AddStudents(); break;
                    case 3: manager.GradeStudents(); break;
                    case 4: manager.ShowInfo(); break;
                    case 0: break;
                    default: System.Console.WriteLine("Invalid choice!!!!!"); break;
                }
            }
        }
    }
}
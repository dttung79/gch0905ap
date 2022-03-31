using System;
// author:Vu Binh Chuong
namespace PersonProject
{
    public class ClassManagement
    {
        private ClassRoom classRoom;
        public ClassManagement()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            classRoom = new ClassRoom(name);
        }
        public void Run()
        {
             while (true)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if(choice == 0) break;
            }
        }
        private void PrintMenu()
        {
            System.Console.WriteLine("----------Menu----------");
            System.Console.WriteLine("1 Add student");
            System.Console.WriteLine("2 Ass teacher");
            System.Console.WriteLine("3 Show infomation");
            System.Console.WriteLine("4 Exit");
        }
        private int GetChoice()
        {
            System.Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        private void DoTask(int choice)
        {
            switch(choice)
            {
                case 1: AddStudents(); break;
                case 2: AssTeacher(); break;
                case 3: ShowInfo(); break;
                case 4: System.Console.WriteLine("Good bye!!!"); break;
                default : System.Console.WriteLine("Invalid choice"); break;
            }

        }

        private void AddStudents()
        {
            System.Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            Student s = new Student(name, age, grade);
            classRoom.AddStudents(s);
            s.ShowInfo();
        }
        private void AssTeacher()
        {
            System.Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Course");
            string course = Console.ReadLine();
            Teacher t = new Teacher(name, age, course);
            classRoom.AssignTeacher(t);
            t.ShowInfo();
        }
        private void ShowInfo()
        {
            classRoom.ShowInfo();
        }
    }
}
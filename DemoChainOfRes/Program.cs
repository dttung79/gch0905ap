using System;

namespace DemoChainOfRes
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 3-5 students
            Student s1 = new Student("John");
            Student s2 = new Student("Mary");
            Student s3 = new Student("Bob");
            Student s4 = new Student("Jane");
            Student s5 = new Student("Sam");
            
            // create 2 fgw classes, add students to classes
            FGWClass fgw1 = new FGWClass("Math", "8:00am");
            fgw1.AddStudent(s1);
            fgw1.AddStudent(s2);

            FGWClass fgw2 = new FGWClass("English", "10:00am");
            fgw2.AddStudent(s3);
            fgw2.AddStudent(s4);
            fgw2.AddStudent(s5);

            // create scheduler, add classes to scheduler
            Scheduler scheduler = new Scheduler();
            scheduler.AddClass(fgw1);
            scheduler.AddClass(fgw2);

            // create academic staff, set next to scheduler
            AcademicStaff academicStaff = new AcademicStaff();
            academicStaff.Next = scheduler;

            // create accounter, set next to academic staff
            Accounter accounter = new Accounter();
            accounter.Next = academicStaff;

            // enroll new student
            // ask student name
            System.Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            // create new student
            Student newStudent = new Student(name);
            // call Enroll method from accounter
            accounter.Enroll(newStudent);

        }
    }
}

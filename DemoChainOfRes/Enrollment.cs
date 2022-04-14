using System;
using System.Collections.Generic;

namespace DemoChainOfRes
{
    public abstract class Enrollment
    {
        public Enrollment Next { get; set; }

        public abstract void Enroll(Student s);
    }

    public class Accounter : Enrollment
    {
        public override void Enroll(Student s)
        {
            System.Console.WriteLine("Enroll fee is $499.99");
            System.Console.Write("Do you want to enroll? (y/n) ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                s.Fee = true;
                System.Console.WriteLine("Student Paid Fee! Please go to Academic Staff.");
                Console.ReadLine();
                Next.Enroll(s);
            }
            else
            {
                System.Console.WriteLine("Not enrolled!");
            }
        }
    }

    public class AcademicStaff : Enrollment
    {
        private int count = 0;
        public override void Enroll(Student s)
        {
            if (s.Fee == false)
            {
                System.Console.WriteLine("Student did not pay fee!");
                return;
            }
            // enroll student
            s.ID = count++;
            System.Console.Write("Enter class name: ");
            string className = Console.ReadLine();
            s.ClassName = className;

            System.Console.WriteLine("Student enrolled!");
            System.Console.WriteLine("Student ID: " + s.ID);
            System.Console.WriteLine("Student Name: " + s.Name);

            System.Console.WriteLine("Next is scheduler...");
            Console.ReadLine();

            Next.Enroll(s);
        }


    }

    public class Scheduler : Enrollment
    {
        public List<FGWClass> classes = new List<FGWClass>();
        public void AddClass(FGWClass c)
        {
            classes.Add(c);
        }
        public override void Enroll(Student s)
        {
            if (s.ClassName == "No Class")
            {
                System.Console.WriteLine("Student did not enroll!");
                return;
            }
            foreach (FGWClass c in classes)
            {
                if (c.Name == s.ClassName)
                {
                    c.AddStudent(s);
                    System.Console.WriteLine("Student enrolled in class " + c.Name);
                    System.Console.WriteLine("Class Time: " + c.ClassTime);
                    System.Console.WriteLine("Students in class: ");
                    foreach (Student st in c.Students)
                    {
                        System.Console.WriteLine("\t" + st.Name);
                    }
                    return;
                }
            }
            System.Console.WriteLine("Enrollment completed!");
        }
    }
}
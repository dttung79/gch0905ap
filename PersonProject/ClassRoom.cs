using System;
using System.Collections.Generic;
// author: Vu Binh Chuong
namespace PersonProject
{
    public class ClassRoom
    {
        private string name;
        private List<Student> students;
        private Teacher teacher;
        public string Name
        {
            get {return name;}
            set{
                if (value == "" ) System.Console.WriteLine("Invalid!!");
                else value = name;
            }  
        }
        public ClassRoom(string name)
        {
            Name = name;
            students = new List<Student>();
            teacher = new Teacher();
        }
        public void AddStudents(Student s)
        {
            students.Add(s);
        }
        public void AssignTeacher(Teacher t)
        {
            teacher = t;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine(" Student ");
            if (students.Count == 0) System.Console.WriteLine("No students");
            else foreach(Student s in students) s.ShowInfo();
            System.Console.WriteLine(" Teacher ");
            teacher.ShowInfo();

        }

    }
}
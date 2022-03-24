using System;

namespace ClassroomManagement
{
    public class Teacher
    {
        private string name;
        private string course;

        public string Name{
            get{return name;}
            set{name = value;}
        }
        public string Course{
            get{return course;}
            set{course = value;}
        }

        public Teacher(){
            name = "Test Teacher";
            course = "C# advanced";
        }

        public Teacher(string name, string course){
            Name = name;
            Course = course;
        }

        public void Grade(Student s){
            System.Console.Write("Enter grade: ");
            double grade = double.Parse(Console.ReadLine());
            s.Grade = grade;
        }

        public void ShowInfo(){
            System.Console.WriteLine("Name Teacher: " + name);
            System.Console.WriteLine("Course: " + course);
        }
    }
}
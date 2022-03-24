using System;

namespace ClassroomManagement
{
    public class Student
    {
        private string name;
        private string id;
        private double grade;

        public string Name{
            get{return name;}
            set{name = value;}
        }

        public string Id{
            get{return id;}
            set{id = value;}
        }

        public double Grade{
            get{return grade;}
            set{grade = value;}
        }

        public Student(){
            name = "test";
            id = "GCH001";
            grade = 0.0;
        }

        public Student(string name, string id){
            Name = name;
            Id = id;
        }

        public void ShowInfo(){
            System.Console.WriteLine("Name student: " + name);
            System.Console.WriteLine("Id student: " + id);
            System.Console.WriteLine("Grade student: " + grade);
        }
    }
}
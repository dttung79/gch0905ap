using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonProject
{
    public class Student : Person
    {
        private double grade;
        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student() : base("John Doe", 18)
        {
            grade = 0.0;
        }

        public Student(string name, int age, double grade) : base(name, age)
        {
            Grade = grade;
        }

        public void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Grade: " + grade);
        }
    }
}
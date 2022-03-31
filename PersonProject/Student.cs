using System;
using System.Collections.Generic; // for class List

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

        public override void ShowInfo()
        {
            base.ShowInfo();

            System.Console.WriteLine("Grade: " + grade);
        }
    }
}
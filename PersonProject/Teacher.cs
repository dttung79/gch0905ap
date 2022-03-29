using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonProject
{
    public class Teacher : Person
    {
        private string course;
        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public Teacher() : base("John Doe", 25)
        {
            course = "Advaned Programming";
        }

        public Teacher(string name, int age, string course) : base(name, age)
        {
            Course = course;
        }

        public void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Course: " + course);
        }
    }
}
using System;

namespace HelloWorld
{
    public class Student
    {
        private int age;
        private double grade;

        public void SetAge(int age)
        {
            if (age < 18 || age > 26) 
            {
                Console.WriteLine("Invalid age!");
                this.age = 18;
            }
            else this.age = age;
        }
        public int GetAge()
        {
            return age;
        }

        public double Grade 
        {
            get
            {
                return grade;
            }

            set 
            {
                if (value < 0 || value > 10)
                {
                    Console.WriteLine("Invalid grade!");
                    grade = 0;
                }
                else grade = value;
            }
        }

        public string name;

        public Student() // default constructor
        {
            name = "No name";
            age = 18;
            grade = 1.0;
        }

        public Student(string name, int age, double grade)
        {
            this.name = name;      
            Grade = grade;        // use Set property
            SetAge(age);          // use Set method
        }
    }
}
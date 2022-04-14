using System;
using System.Collections.Generic;

namespace DemoChainOfRes
{
    public class FGWClass
    {
        public string Name { get; set; }
        public string ClassTime { get; set; }
        private List<Student> students;
        public List<Student> Students
        {
            get
            {
                return students;
            }
        }

        public FGWClass(string name, string classTime)
        {
            Name = name;
            ClassTime = classTime;
            students = new List<Student>();
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }
    }
}
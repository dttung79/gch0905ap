using System;

namespace ClassroomManagement
{
    public class ClassRoom
    {
        private List<Student> listStudents;

        private Teacher teacher;

        public ClassRoom(){
            listStudents = new List<Student>();
            teacher = new Teacher();
        }

        public void AddTeacher(){
            
            System.Console.Write("Enter Name Teacher: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            teacher.Name = name;
            teacher.Course = course;
        }

        public void AddStudents(){
            System.Console.Write("Enter Name Student: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter Id: ");
            string id = Console.ReadLine();

            Student s = new Student(name, id);

            listStudents.Add(s);
        }

        public void GradeStudents(){
            foreach (Student s in listStudents){
                s.ShowInfo();
                teacher.Grade(s);
            }
        }

        public void ShowInfo(){
            Console.WriteLine("---------------TEACHER--------------");
            teacher.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("---------------STUDENTS--------------");
            foreach (Student s in listStudents){
                s.ShowInfo();
                Console.WriteLine("");
            }

        }
    }
}
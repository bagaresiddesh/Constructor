using System;
namespace StudentClass
{
    public class Student
    {
        public static string Name;
        public static int Rno;

        private Student()//Private constructor
        {
            Console.WriteLine("private Constructor of Studnet called");
        }

        public Student(string name, int rno)//Default constructor with parameters
        {
            Console.WriteLine("default Constructor with parameters called");
            Name = name;
            Rno = rno;
        }

        public void DisplayName()
        {
            Console.WriteLine("Student Name : {0}", Student.Name);
        }
    }

    public static class NewStudent //Extension class of student
    {
        public static void DisplayRollNo(this Student S1)
        {
            Console.WriteLine("Extension of Student class function called");
            Console.WriteLine("Student Roll no : {0}", Student.Rno);
        }
    }
}



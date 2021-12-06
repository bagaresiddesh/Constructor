using System;

namespace ClassLibrary
{
    public enum EGender
    {
        Male = 1,
        Female = 2,
        Other = 3
    }

    public class Person
    {
        public string FirstName;
        public string LastName;
        public EGender Gender;
        public int Age;

        public Person()//Default Constructor
        {
            Console.WriteLine("default Constructor called");
            FirstName = "Siddesh";
            LastName = "Bagare";
            Gender = EGender.Male;
            Age = 22;
        }

        public Person(string fname, string lname, EGender gender, int age)//Parametrized Constructor 
        {
            Console.WriteLine("parametrized Constructor called");
            FirstName = fname;
            LastName = lname;
            Gender = gender;
            Age = age;
        }

        public Person(Person person)//Copy Constructor
        {
            Console.WriteLine("copy Constructor called\n");
            FirstName = person.FirstName;
            LastName = person.LastName;
            Gender = person.Gender;
            Age = person.Age;
        }

        static Person()//Static Constructor
        {
            Console.WriteLine("static Constructor called");
        }

        public void Display()
        {
            Console.WriteLine("Details :");
            Console.WriteLine("First Name : {0}", FirstName);
            Console.WriteLine("Last Name : {0}", LastName);
            Console.WriteLine("Age : {0}", Age);
            Console.WriteLine("Gender : {0}", Gender);
            Console.WriteLine("--------------------------------");
        }
    }

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




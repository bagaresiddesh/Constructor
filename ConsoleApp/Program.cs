using System;
using ClassLibrary;

namespace Class
{
    class Program
    {
        public static void Main()
        {
            int age;

            Person P = new Person();//Default Constructor 
            Person P1 = new Person();//Parametrized Constructor 

            Console.WriteLine("\nPlease enter your Details");
            Console.WriteLine("\nEnter your First Name");
            P1.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            P1.LastName = Console.ReadLine();

            Console.WriteLine("Enter your Age");
            age = Convert.ToInt32(Console.ReadLine());
            P1.Age = age;

            Console.WriteLine("Select your Gender and enter a number");
            Console.WriteLine("1.Male    2.Female    3.Other");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            switch (choice)
            {
                case 1:
                    P1.Gender = EGender.Male;
                    break;
                case 2:
                    P1.Gender = EGender.Female;
                    break;
                case 3:
                    P1.Gender = EGender.Other;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Person P2 = new Person("Sukanya", "Joshi", EGender.Female, 26);//Parametrized Constructor 
            Person P3 = new Person(P1);//copy Constructor 

            Console.WriteLine("Default Constructor:");
            P.Display();//Default Constructor called

            Console.WriteLine("Parametrized Constructor:");
            P1.Display();//Parametrized Constructor called

            Console.WriteLine("Parametrized Constructor:");
            P2.Display();//Parametrized Constructor called

            Console.WriteLine("Copy Constructor:");
            P3.Display();//Copy Constructor called

            object box = age;//boxing
            box = 30;

            Console.WriteLine("\nBoxing complete");
            Console.WriteLine("value of age : {0}", age);
            Console.WriteLine("value of box : {0}", box);

            age = (int)box;//unboxing
            Console.WriteLine("\nUnboxing complete");
            Console.WriteLine("value of age : {0}", age);
            Console.WriteLine("value of box : {0}", box);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Passing Value Type Variables");
            Console.WriteLine("Value of age before function call : {0}", age);
            ChangeValueType(age);//Passing Value Type Variables
            Console.WriteLine("Value of age after function call : {0}", age);

            void ChangeValueType(int x)
            {
                x = 50;
                Console.WriteLine("Value of age inside function : {0}", x);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Passing Reference Type Variables");

            Person P4 = new Person
            {
                FirstName = "Steve"
            };

            Console.WriteLine("Person name before function : {0}", P4.FirstName);
            ChangeReferenceType(P4);//Passing Reference Type Variables
            Console.WriteLine("Person name after function : {0}", P4.FirstName);

            void ChangeReferenceType(Person P5)
            {
                P5.FirstName = "Henry";
            }

            Console.WriteLine("--------------------------------");
            //Console.WriteLine("Private constructor");           
            //Student S1 = new Student(); //call not allowed due to private constructor
            
            Student S2 = new Student("Rahul", 11);
            S2.DisplayName();
            S2.DisplayRollNo();//Extension class function called

            Console.ReadLine();
        }
    }
}

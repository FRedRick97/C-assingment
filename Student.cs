using System;

namespace assingment
{
    class Student
    {
        static Random rnd;

        static Student()
        {
            rnd = new Random();
        }
        public String name {
            get;
        }
        public int age {
            get;
        }

        public int StudentEnrollmentNo  {
            get;
        }

        enum StudentAttribute
        {
            name = 1, age, StudentEnrollmentNo
        }

        public Student(String name, int age)
        {
            this.name = name;
            this.age = age;
            this.StudentEnrollmentNo = rnd.Next(1000);
        }

        public void display()
        {
            Console.WriteLine($"Student Enrollment No. = {this.StudentEnrollmentNo}\nStudent Name = {this.name}\nStudent Age = {this.age}");
            Console.WriteLine("\n");
        }

        public static void EntryPoint()
        {
            Console.WriteLine("Enter Student name, age in order :");
            String name = Console.ReadLine();
            int age = Int32.Parse(Console.ReadLine());

            Student obj = new Student(name, age);

            Console.WriteLine("Which Attribute you'd like to display?");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Age");
            Console.WriteLine("3. StudentEnrollmentNo");

            int option = Int32.Parse(Console.ReadLine());

            switch(option)
            {
                case (int)StudentAttribute.name:
                    Console.WriteLine($"Name = {obj.name}");
                    break;

                case (int)StudentAttribute.age:
                    Console.WriteLine($"Age = {obj.age}");
                    break;
                case (int)StudentAttribute.StudentEnrollmentNo:
                    Console.WriteLine($"StudentEnrollmentNo = {obj.StudentEnrollmentNo}");
                    break;
                default:
                    Console.WriteLine("Incorrect option. Exiting........");
                    break;
            }
        }
    }
}
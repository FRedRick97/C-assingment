using System;

namespace assingment
{
    class StudentInheritance
    {
        private int _age;
        private int _rollNo;

        protected int Age
        {
            get => _age;
            set => _age = value;
        }

        protected int RollNo
        {
            get => _rollNo;
            set => _rollNo = value;
        }
        
        public static void EntryPoint()
        {
            StudentInheritance s;
            s = new SchoolStudents(14, 21, 7, "John Doe");
            ((SchoolStudents)s).display();
            Console.WriteLine("\n");
            s = new CollegeStudents(21, 33, "IT", "Jane Scofield");
            ((CollegeStudents)s).display();
            
        }
    }
    class SchoolStudents : StudentInheritance
    {
        private int grade;
        private String name;

        public SchoolStudents(int age, int rollNo, int grade, String name) : base()
        {
            Age = age;
            RollNo = rollNo;
            this.grade = grade;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"School Student Name : {this.name}\nSchool Student Roll No. : {RollNo}\nSchool Student grade : {this.grade}\nStudent Age : {Age}");
        }
    }   

    class CollegeStudents : StudentInheritance
    {
        private String field;
        private String name;

        public CollegeStudents(int age, int rollNo, String field, String name) : base()
        {
            Age = age;
            RollNo = rollNo;
            this.field = field;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"College Student Name : {this.name}\nCollege Student Roll No. : {RollNo}\nCollege Student Field : {this.field}\nCollege Student Age : {Age}");
        }
    }   
}























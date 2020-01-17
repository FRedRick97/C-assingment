// using System;

// namespace assingment
// {
//     class StudentAccess
//     {
//         public int _age;
//         int _rollNo;
//     }
//     class CollegeStudent
//     {
//         public static void Main()
//         {
//             CollegeStudent stu = new CollegeStudent();
//             stu._age = 10;
//         }
//     }
// }


// code will fail because field _age has an access specifier of protected 
// and class CollegeStudent doesn't inherit its class.


// Problem 2

// Code will fail to run because protected internal is supposed to give access within the assembly
using System;

namespace assingment
{
    enum WeekDays
    {
        Monday=1, Tuesday, Wednesday,  Thursday, Friday, Saturday, Sunday
    }
    class TestEnum
    {
        public static void EntryPoint()
        {
            Console.WriteLine("Enter a number:");
            int week = Int32.Parse(Console.ReadLine());

            switch(week)
            {
                case (int)WeekDays.Monday:
                    Console.WriteLine("It's Monday!!");
                    break;
                case (int)WeekDays.Tuesday:
                    Console.WriteLine("It's Tuesday!!");
                    break;
                case (int)WeekDays.Wednesday:
                    Console.WriteLine("It's Wednesday!!");
                    break;
                case (int)WeekDays.Thursday:
                    Console.WriteLine("It's Thursday!!");
                    break;
                case (int)WeekDays.Friday:
                    Console.WriteLine("It's Friday!!");
                    break;
                case (int)WeekDays.Saturday:
                    Console.WriteLine("It's Saturday!!");
                    break;
                case (int)WeekDays.Sunday:
                    Console.WriteLine("It's Sunday!!");
                    break;
                default:
                    Console.WriteLine("Ran out of week days!!");
                    break;
            }
        }
    }
}

using System;

namespace assingment
{
    class TestSwitch
    {
        public static void EntryPoint()
        {
            Console.WriteLine("Enter :");
            String str = Console.ReadLine();

            switch(str)
            {
                case "VB": 
                    Console.WriteLine("VB .NET: OOP, multithreading and more!");
                    break;
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }
    }
}

using System;

namespace assingment
{
    class TestIf
    {
        public static void EntryPoint()
        {
            Console.WriteLine("Enter :");
            String str = Console.ReadLine();

            if(str == "VB") Console.WriteLine("VB .NET: OOP, multithreading and more!");
            else if(str == "C#") Console.WriteLine("Good choice, C# is a fine language.");
            else Console.WriteLine("Well...good luck with that!");
        }
    }
}

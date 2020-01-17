using System;

namespace assingment
{
    class TestStrings
    {
        public static void EntryPoint()
        {
            String str = "Hello world";

            // Clone() creates a clone of string.
            Console.WriteLine(str.Clone());

            // CompareTo() returns 0 if same order
            // returns -1 if instance precedes
            // else greater than 1
            Console.WriteLine("zzezz".CompareTo("zzezzb"));

            // EndsWith() checks string's ends. Returns true if equal
            Console.WriteLine(str.EndsWith("world"));

            // toUpper and toLower
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());

            // split()

            String[] arr = str.Split(' ');
            foreach(string word in arr) Console.WriteLine(word);
        }
    }
}

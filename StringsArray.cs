using System;

namespace assingment
{
    class StringsArray
    {
        static String[] GetStringArray()
        {
            return new String[] {"Hello", "World", "Minecraft", "Razer", "Slope"};
        }
        public static void EntryPoint()
        {
           String[] strArr = GetStringArray();
           foreach(String str in strArr) Console.WriteLine(str);
        }
    }
}

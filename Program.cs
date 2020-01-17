using System;

namespace assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;     
            do
            {
                Console.WriteLine("\n\n\nEnter which file to run (0 to quit):");
                
                Console.WriteLine("1. TestIf");
                Console.WriteLine("2. TestSwitch");
                Console.WriteLine("3. TestEnum");
                Console.WriteLine("4. TestStrings");
                Console.WriteLine("5. StringsArray");
                Console.WriteLine("6. Books");
                Console.WriteLine("7. Saving Accounts");
                Console.WriteLine("8. Student");
                Console.WriteLine("9. Vehicle");
                Console.WriteLine("11. Student Inheritance");

                option = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");
                switch(option)
                {
                    case 1:
                        TestIf.EntryPoint();
                        break;
                    case 2: 
                        TestSwitch.EntryPoint();
                        break;
                    case 3:
                        TestEnum.EntryPoint();
                        break;
                    case 4:
                        TestStrings.EntryPoint();
                        break;
                    case 5:
                        StringsArray.EntryPoint();
                        break;
                    case 6:
                        Book.EntryPoint();
                        break;
                    case 7:
                        SavingsAccount.EntryPoint();
                        break;
                    case 8:
                        Student.EntryPoint();
                        break;
                    case 9:
                        Vehicle.EntryPoint();
                        break;
                    case 11:
                        StudentInheritance.EntryPoint();
                        break;
                    default:
                        Console.WriteLine("Out of range!!!");
                        break;
                }
            } while(option != 0);
            Console.WriteLine("**** EXITING ****");
        }
    }
}

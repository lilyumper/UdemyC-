using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't devide by zero");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
                }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception, the number was too long or too short for an int32");
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullExpection, the value empty(null)");

            }

            finally{
                Console.WriteLine("this is called anyways");
            }




            Console.ReadKey();
        }
    }
}

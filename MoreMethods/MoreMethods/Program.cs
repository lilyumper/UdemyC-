using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //Console.WriteLine(input);
            //Console.Read();

            Console.WriteLine(Calculate());
            Console.Read();



        }
        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2input = Console.ReadLine();

            int num1 = int.Parse(number1input);
            int num2 = int.Parse(number2input);

            int result = num1 + num2;
            return result;
        }
    }
}

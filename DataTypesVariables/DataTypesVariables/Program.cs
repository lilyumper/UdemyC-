using System;

namespace DataTypesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string Mystring = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(Mystring);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = Mystring + mySecondString;

            Console.WriteLine(resultInt);
            Console.Read();
        }
    }
}

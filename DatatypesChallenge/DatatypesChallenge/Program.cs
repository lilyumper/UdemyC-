using System;

namespace DatatypesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte

            byte thisbyte = 8;

            Console.WriteLine(thisbyte);

            //sbyte 
            sbyte anotherByte = -33;

            Console.WriteLine(anotherByte);

            //int
            int num1 = 23;

            Console.WriteLine(num1);
            //uint

            uint unassignedNum = 2;

            Console.WriteLine(unassignedNum);

            //short

            short shortie = 23400;

            Console.WriteLine(shortie);

            //ushort ... unassignedshort cant be negative

            ushort uShortie = 55;

            Console.WriteLine(uShortie);

            //long

            long longJohn = 555555;

            Console.WriteLine(longJohn);
            //ulong... cant be negative

            ulong Silver = 234342423;

            Console.WriteLine(Silver);

            //float
            float myFloat = 3.14F;
            Console.WriteLine(myFloat);
            //double

            double myDouble = 1.555555;

            Console.WriteLine(myDouble);
            //char

            char myChar = 't';

            Console.WriteLine(myChar);

            //string

            string myString = "I control text";

            string anotherString = "13";

            Console.WriteLine(myString + anotherString);

            //parse
            int parsed = Int32.Parse(anotherString);


            Console.WriteLine(parsed);

        }
    }
}

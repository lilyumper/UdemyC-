using System;

namespace DatatypesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte

            byte thisbyte = 8;

            //sbyte 
            sbyte anotherByte = -33;

            //int
            int num1 = 23;

            //uint

            uint unassignedNum = 2;

            //short

            short shortie = 23400;

            //ushort ... unassignedshort cant be negative

            ushort uShortie = 55;

            //long

            long longJohn = 555555;

            //ulong... cant be negative

            ulong Silver = 234342423;

            //float
            float myFloat = 3.14F;

            //double

            double myDouble = 1.555555;

            //char

            char myChar = 't';

            //string

            string myString = "I control text";

            string anotherString = "13";

            //parse
            int parsed = Int32.Parse(anotherString);


            Console.WriteLine(parsed);

        }
    }
}

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            // implicit Conversion
            int num = 1234578;
            long bignum = num;

            double myDobule = 13.37;
            float myFloat = 13.37F;

            double myNewDouble = myFloat;
            int myInt;

            //explicit conversion
            // cast double to int;

            myInt = (int)myDobule;

            // typeConversion
            string myString = myDobule.ToString(); // "13.37"
            string NewString = myFloat.ToString();
            bool sunisShining = false;
            string myBoolString = sunisShining.ToString();
            Console.WriteLine(myBoolString);
            Console.Read();

            //


        }
    }
}

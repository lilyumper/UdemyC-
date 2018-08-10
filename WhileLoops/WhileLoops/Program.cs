using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            int peoplecounter = 0;
            string entry = "";

            while (entry.Equals(""))
            {
                Console.WriteLine("PLease press enter while blank to count students");
                entry = Console.ReadLine();
                peoplecounter++;
                Console.WriteLine("Current student count is {0}", peoplecounter);
            }
            Console.WriteLine("{0} students are inside the bus. Please press enter to end program", peoplecounter);
        }
    }

}

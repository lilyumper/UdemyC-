using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");

            Console.WriteLine(About());
        }

        public static int About()
        {
            string UserAge = Console.ReadLine();


            int userinput = int.Parse(UserAge);

            if (userinput > 17 && userinput < 35)
            {
                Console.WriteLine("You are still very young!");

            }
            else if (userinput > 35 && userinput < 50)
            {
                Console.WriteLine("Welcome to Middle Age");
            }
            else if (userinput > 50)
            {
                Console.WriteLine("Welcome to the Old Age!!!");

            }
            else
            {
                Console.WriteLine("You a child still!!!");
            }

            return userinput;
        }

    }
}
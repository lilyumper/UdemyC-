using System;

namespace OOPClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an objec of my class
            // an instance of human
            Human denis = new Human();
            //access public variable from outside, and even change it
            denis.firstName = "Denis";
            //call mehthods of the class
            denis.IntroduceMyself();
            Human Tom = new Human();
            Tom.firstName = "Tom";
            Tom.IntroduceMyself();

            //Challenge
            Human Vinny = new Human();
            Vinny.firstName = "Vinny";
            Vinny.lastName = "Garcia";
            Vinny.IntroduceMyself();

            Human Jenny = new Human();
            Jenny.firstName = "Jenny";
            Jenny.lastName = "Garcia";
            Jenny.IntroduceMyself();


            Console.ReadKey();

        }
    }
}

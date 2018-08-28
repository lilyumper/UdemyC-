using System;

namespace OOPClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an objec of my class
            // an instance of human
            Human denis = new Human("Denis", "Jones","Brown", 22);
            //access public variable from outside, and even change it
            //call mehthods of the class
            denis.IntroduceMyself();
            Human Tom = new Human("Tom", "Garcia", "Brown", 33);
            Tom.IntroduceMyself();


            Human Vinny = new Human("Vinny", "Garcia", "Blue", 2);
           
            Vinny.IntroduceMyself();

            Human Jenny = new Human("Jenny", "Garcia", "Blue",34);
            Jenny.IntroduceMyself();
            //Challenge additions
            Human Tumble = new Human("Tumblina", "Garcia", "Brown", 53);
            Tumble.IntroduceMyself();

            Human Matthew = new Human("Matthew", "Garcia", "Brown", 28);
            Matthew.IntroduceMyself();


            Console.ReadKey();

        }
    }
}

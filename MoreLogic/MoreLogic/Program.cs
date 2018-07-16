using System;

namespace MoreLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the Temperature?" );
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            if(int.TryParse(temperature, out number)){
                numTemp = number;
                
            }
            else{
                numTemp = 0;
                Console.WriteLine("Value Entered, was not a valid number. 0 set as temperature");
            }

            if(numTemp < 50){
                Console.WriteLine("Take a Coat");
            }

            else if(numTemp == 60){
                Console.WriteLine("Pants and Pull Over should be fine");
            }
            else if (numTemp > 90){
                Console.WriteLine("Its Super Hot");
            }

            else {
                Console.WriteLine("Shorts are enough today");
            }
            Console.Read();
        }
    }
}

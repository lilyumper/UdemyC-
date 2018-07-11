using System;

namespace LogicConditions
{
    class Program
    {
        static void Main(string[] args)
        {

            TempCheck();
            Console.Read();
        }

        public static void TempCheck(){
            Console.WriteLine("Please enter a Temperature (number only)");
            string temperature = Console.ReadLine();

            int Temp = int.Parse(temperature);

            if (Temp < 60)
            {
                Console.WriteLine("Take the Coat");
            }
            
            if (Temp == 10)
            {
                Console.WriteLine("It's 10 degrees F!!! IT's A COLD ONE!!");
            }
            
            if (Temp > 70)
            {
                Console.WriteLine("Bring out the shorts!");
            }
            if (Temp >60 && Temp <69){
                Console.WriteLine("No need for a winter coat, wind breaker maybe!");
            }


        }

        }

    }


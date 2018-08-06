using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int counter = 0; counter < 20; counter++){
                if(counter % 2 == 1){
                    
                    Console.WriteLine(counter);
                }

            }
            Console.WriteLine("the Loop is done!");
            Console.Read();
        }
    }
}

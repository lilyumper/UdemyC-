﻿using System;

namespace EnhancedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = -5;
            string stateOfMatter;


            if(temperature <0){
                stateOfMatter = "solid";
            }
            else{
                stateOfMatter = "liquid";
            }
            //in short
            temperature += 30;
            Console.WriteLine("State of Matter is {0}", stateOfMatter);

            temperature += 100;
            stateOfMatter = temperature >100 ? "gas" : (temperature < 0 ? "solid" : "liquid");
            Console.WriteLine("State of Matter is {0}", stateOfMatter);

        }
    }
}

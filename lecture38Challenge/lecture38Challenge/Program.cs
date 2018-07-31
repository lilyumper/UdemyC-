using System;

namespace lecture38Challenge
{
    class Program
    {
        static int highscore;
        static string name;

        static void Main(string[] args)
        {
            HighscoreCheck();
        }

        static void HighscoreCheck(){
            Console.WriteLine("Please Enter your username");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter your score");
            highscore = int.Parse(Console.ReadLine());

            int prevHighscore = 1000;
            string highscoreleader = "George";

            if(highscore > prevHighscore){
                prevHighscore = highscore;
                highscoreleader = name;
                Console.WriteLine(name + "You now have the highest score of the game with " + highscore + " points");

            }
            else{
                Console.WriteLine("You still trail " + highscoreleader + " by " + (prevHighscore - highscore)+ " points");
            }
        }
    }
}

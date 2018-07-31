using System;

namespace lecture38Challenge
{
    class Program
    {
        static int highscore = 10000;
        static string name = "Toby";

        static void Main(string[] args)
        {
            HighscoreCheck(9000, "Tim");
            HighscoreCheck(24000, "Tommy G");
            HighscoreCheck(15000, "Vinny");

        }

        static void HighscoreCheck(int score, string playername){
           

            if(score > highscore){
                highscore = score;
                name = playername;
                Console.WriteLine(name + " You now have the highest score of the game with " + highscore + " points");

            }
            else{
                Console.WriteLine("You still trail " + name + " by " + (highscore - score)+ " points");
            }
        }
    }
}

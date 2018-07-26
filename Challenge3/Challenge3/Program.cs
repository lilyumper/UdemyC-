using System;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRegistered = false;
            bool loggedIn = false;
            string userName = "";
            string registerPassword = "";
            string loginPassword = "";
            string loginUsername = "";
            Console.WriteLine("Please enter your Username to register");
            userName = Console.ReadLine();
            Console.WriteLine("Please enter your Password");
            registerPassword = Console.ReadLine();

            if(userName != "" && registerPassword != ""){
                Console.WriteLine("Congrats " + userName + " You are now registered");
                Console.WriteLine("Please enter your username");
                 isRegistered = true;
                loginUsername = Console.ReadLine();
                Console.WriteLine("Please Enter your Password");
                loginPassword = Console.ReadLine();
                if(loginUsername.Equals(userName) && loginPassword.Equals(registerPassword)){
                    loggedIn = true;
                    Console.WriteLine("Congrats you are logged in");
                }
                else{
                    Console.WriteLine("Your username or password were incorrect");
                }

            }
            else{
                Console.WriteLine("You need to enter a valid username/password");
            }
            Console.Read();

        }
    }
}

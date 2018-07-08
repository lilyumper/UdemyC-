using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecfic("I am an Argument and am Called from a Method Buddy!!!!!");
            Console.WriteLine(Add(15,31));
            Console.WriteLine(Multiply(25, 25));
            Console.WriteLine(Divide(25,14));
            Console.WriteLine(GreetFriend("Sammy"));
            Console.WriteLine(GreetFriend("Bobby"));
            Console.WriteLine(GreetFriend("Tony"));
            Console.Read();
        }

        //access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine(" I am called from a method");
           
        }

        public static void WriteSomethingSpecfic(string myText){
            Console.WriteLine(myText);
             
        }

        public static int Add(int parameter1, int parameter2)
        {
            return parameter1 + parameter2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static double Divide(double x, double y){
            return x / y;
        }

        //Challenge

        public static string GreetFriend(string name){
            return ("Hi " + name + ", My Friend!"); 
        }
    }
}

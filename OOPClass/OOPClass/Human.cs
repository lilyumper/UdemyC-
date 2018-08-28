using System;
namespace OOPClass
{
    //blueprint for a datatype
    public class Human
    {
            //challenge
            // add two more member variables to "Human" eyecolor and age.
            // adjust the constructor, so it requires all the four values to be used, when creating an object of Human.
            // create two objects of type human

            //member variable
           private string firstName;
            private string lastName;
        private string eyeColor;
        private int age;

        // Constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        

            //member method
            public void IntroduceMyself()
            {
            Console.WriteLine("Hi, im {0} {1}, My eye color is {2} and I am {3} years old", firstName, lastName, eyeColor,age);
            }


        }
    }


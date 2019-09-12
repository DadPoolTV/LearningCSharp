using System;

namespace CA_Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Loki!");
            Console.WriteLine("I am curious, what is your favorite Color?");
            //So colorInput is the variable name here, and string is the variable type
            string colorInput = Console.ReadLine();
            //{colorInput} is how we call the variable that we created of type string and I believe that the $ before the "" tells compiler that there is a variable
            Console.WriteLine($"Youre favorite color is {colorInput}!");

            //Lets try something new here
            Console.WriteLine("Lets ask another question! How old are you?");
            /* the code below will not run as Console.ReadLine(); requires it to be of type string
            int ageInput = Console.ReadLine();
            */

            string ageInput = Console.ReadLine();

            Console.WriteLine($"Oh coolio! You are {ageInput} years old!");

            Console.WriteLine("I suppose this is the end of messing around with text :)");
        }
    }
}

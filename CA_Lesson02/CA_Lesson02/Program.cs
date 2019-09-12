using System;

namespace CA_Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Variables
            string name = "Shadow";
            string breed = "Golden Retriever";
            int age = 5;
            double weight = 65.22;
            bool spayed = true;

            // Print variables to the console
            Console.WriteLine(name);
            Console.WriteLine(breed);
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(spayed);

            //Impicit and Explicit Conversion

            int faveNumber = 0;

            Console.Write("Please enter your favorite number: ");

            // Turn that answer into an int

            // Attempt 1: use implicit conversion fails
            // faveNumber = Console.ReadLine();

            // Attempt 2: use explicit conversion fails 
            // faveNumber = (int)Console.ReadLine();

            // Attempt 3: use Convert method is the only way to achieve what we want here, NOTE if the user enters anything but a whole number, the entire project will crash
            faveNumber = Convert.ToInt32(Console.ReadLine()); 

            //Output without the $ in front (seen on line 43) results the text showiwing up as it is listed in the statement
            Console.WriteLine("The number you have entered is {faveNumber}");
            //Output with the $ in front (as seen on line 43) results with the text showing with the number the user has entered previously on line 38
            Console.WriteLine($"The number you have entered is {faveNumber}");

        }
    }
}

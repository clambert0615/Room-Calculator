using System;

namespace Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string decision;

            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator");
            do
            {
                //Ask for height, width and length and store as variables
                Console.WriteLine();
                Console.WriteLine("Please enter the length:");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the width:");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the height:");
                double height = double.Parse(Console.ReadLine());
                //create area, perimeter and volume formulas and assign to variables
                double area = length * width;
                double perimeter = (2 * length) + (2 * width);
                double volume = length * width * height;
                //output results to user
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Volume: {volume}");
                Console.WriteLine();
                //ask if user wants to continue
                Console.WriteLine("Continue? y/n");
                decision = Console.ReadLine().ToLower();

                   

            } while (decision == "y");

            if (decision == "n")
            {
                Console.WriteLine("You have chosen to exit. Goodbye!");
            }
        }
    }
}

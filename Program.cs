using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number to check if it is an even or odd number.");
            string userInput;
            userInput = Console.ReadLine();
            //checks if number is larger than zero
            while ( Int32.Parse(userInput) <= 0)
            {
                Console.WriteLine("Please enter a number greater than 0!");
                userInput = Console.ReadLine();
            }
            //checks if number is odd or even
            if (Int32.Parse(userInput) % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            //exit for application
            Console.WriteLine("Please press enter to exit...");
            Console.ReadLine();
        }
    }
}

using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number to check if it is odd or even.");
            string userInput;
            userInput = Console.ReadLine();
            //checks if number is larger than zero
            while ( Int32.Parse(userInput) <= 0)
            {
                Console.WriteLine("Enter a number greater than 0!");
                userInput = Console.ReadLine();
            }
            //checks if number is odd or even
            if (Int32.Parse(userInput) % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
            //exit for application
            Console.WriteLine("Please press enter to exit!");
            Console.ReadLine();
        }
    }
}

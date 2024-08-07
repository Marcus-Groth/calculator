using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            OperationsMenu();

            string userInput = Console.ReadLine();
        }

        static public void OperationsMenu() 
        {
            // Create Input Menu for a calulator
            Console.WriteLine("Basic Operations");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Please select an operation: ");
        }

        static public void handleUserInput(string userInput) 
        {
            switch (userInput)
            {
                case "1":
                 Console.WriteLine("Press 1");
                    break;
                case "2":
                Console.WriteLine("Press 2");
                    break;
                case "3":
                 Console.WriteLine("Press 3");
                    break;
                case "4":
                Console.WriteLine("Press 4");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
        }
        }
    }
}

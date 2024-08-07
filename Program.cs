using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            OperationsMenu();


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

        }
        }
    }
}

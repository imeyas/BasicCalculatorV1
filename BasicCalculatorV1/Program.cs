using System;

namespace BasicCalculatorV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basic Calculator Program - Do-While loop that adds two integers and multiplies the sum by 17

            Console.WriteLine($"\nThis calculator will add two numbers you provide and multipy the sum of those two numbers by 17 and display the answer.");
            do
            {
                Console.WriteLine($"\nX = ");

                var xInput = int.TryParse(Console.ReadLine(), out int xResult);

                Console.WriteLine($"\nY = ");
                var yInput = int.TryParse(Console.ReadLine(), out int yResult);

                var sum = (xResult + yResult) * 17;

                Console.WriteLine($"\n{sum}");

                Console.WriteLine($"\nTo enter a new set of numbers, press Enter. To exit this app, type 'exit.'");
                var exit = Console.ReadLine();
                if (exit == "exit")
                    break;
            }
            while (true);
        }
    }
}


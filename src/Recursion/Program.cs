using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Please, enter number: ");
                string enteringValue = Console.ReadLine();
                int number;

                if ((int.TryParse(enteringValue, out number)) & (number > 1))
                {
                    Console.WriteLine($"\nFactorial (whithout RECURSION) number {number}={WhithoutRecursion.FactorialFor(number)}"); ;

                    Console.WriteLine($"\nFactorial (whith RECURSION) number {number}={Recursion.FactorialRecursion(number)}");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("You entered the wrong number. Please enter number from 1 to 2 147 483 647\n");
                }
            } while (true);
        }
    }
}

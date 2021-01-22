using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Link1:
            Console.Write("Please, enter number: ");
            string enteringValue = Console.ReadLine();

            int number;

            if ((int.TryParse(enteringValue, out number)) & (number > 0))
            {

                static int WhithoutFactorial(int number)
                {
                    int whithoutFactorial = 1;
                    for (int i = 1; i <= number; i++)
                    {
                        whithoutFactorial *= i;

                    }
                    return whithoutFactorial;
                }
                Console.WriteLine("\nFactorial (whithout RECURSION) number {0}={1}", number, WhithoutFactorial(number)); ;

                Console.WriteLine("\nFactorial (whith RECURSION) number {0}={1}", number, Factorial(number));
                Console.WriteLine();

                static int Factorial(int number)
                {
                    if (number == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return number * Factorial(number - 1);
                    }
                }
            }
            else
            {
                Console.Write("You entered the wrong number. Please enter number from 1 to 2 147 483 647\n");
            }
            goto Link1;
        }
    }
}

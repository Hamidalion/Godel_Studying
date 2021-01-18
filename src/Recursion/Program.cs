using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter number: ");
            int number = int.Parse(Console.ReadLine());

            #region withoutRecursion

            //int factorial = 1;

            //for (int i = 1; i <= number; i++)
            //{
            //    factorial *= i;

            //    if (i == number)
            //    {
            //        Console.Write($"{i}=");
            //    }
            //    else
            //    {
            //        Console.Write($"{i}*");
            //    }
            //}
            //Console.Write(factorial);
            //Console.ReadKey();
            //return 0;
            #endregion

            #region withRecursion
            Console.WriteLine("Factorial number {0} = {1}", number, factorial(number));
            Console.ReadLine();
            #endregion
        }

        static int factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * factorial(number - 1);
            }
        }
    }
}

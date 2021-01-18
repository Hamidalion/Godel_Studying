using System;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                bool condition = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        condition = false;
                    }
                }
                if (condition)
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.ReadKey();
        }
    }
}
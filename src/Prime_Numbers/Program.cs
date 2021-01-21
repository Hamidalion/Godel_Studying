using System;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Link1:
            Console.Write("Please, enter number: \n");
            string enteringValue = Console.ReadLine();

            int number;

            if ((int.TryParse(enteringValue, out number)) & (number > 0))
            {
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
                Console.WriteLine("\n");
            }
            else
            {
                Console.Write("You entered the wrong number. Please enter number from 1 to 2 147 483 647\n");
            }
            goto Link1;
        }
    }
}
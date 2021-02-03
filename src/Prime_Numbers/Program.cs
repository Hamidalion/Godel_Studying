using System;
using System.Collections.Generic;
using System.Text;

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
            StringBuilder sb = new StringBuilder();

            

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
        
                        sb.Append($"{i},");
                        //Console.Write($"{i}, ");
                    }
                }
            }

            else
            {
                Console.Write("You entered the wrong number. Please enter number from 1 to 2 147 483 647\n");
            }
            string allText = sb.ToString();
            string withOutLast = allText.Remove(allText.Length - 1);
            Console.WriteLine(withOutLast);
            Console.WriteLine();

            goto Link1;
        }
    }
}
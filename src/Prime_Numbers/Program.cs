using System;
using System.Linq;
using System.Text;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;

            do
            {
                Console.Write("Please, enter number: \n");

                StringBuilder sb = new StringBuilder();
                {
                    try
                    {
                        selection = (int)Convert.ChangeType(Console.ReadLine(), typeof(int));
                    }
                    catch (Exception e)
                    {
                        Type[] expectedExceptions = { typeof(InvalidCastException),
                                                          typeof(FormatException),
                                                          typeof(ArgumentNullException),
                                                          typeof(OverflowException)};
                        if (expectedExceptions.Any(ex => ex == e.GetType()))
                        {
                            Console.WriteLine(e.Message);
                            continue;
                        }
                        throw;
                    }

                    if (selection > 0)
                    {

                        



                        for (int i = 2; i <= selection; i++)
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
                            }
                        }

                        string allText = sb.ToString();
                        string withOutLast = allText.Remove(allText.Length - 1);

                        Console.WriteLine(withOutLast);
                        Console.WriteLine();


                        var primeNumbers = SieveEratosthenes.AddSieveEratosthenes(selection);
                        Console.WriteLine("Prime numbers from {0}:", selection);
                        Console.WriteLine(string.Join(",", primeNumbers));
                    }
                    else
                    {
                        Console.WriteLine("Number must be positive.");
                    }
                }
            } while (true);
        }
    }
}
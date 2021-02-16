using StackBaseonLL.Model;
using System;
using System.Linq;

namespace StackBaseonLL
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new NodeStack<object>();

            int selection = 0;

            do
            {
                Console.WriteLine(new string('-', 40));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("If you want to: add upper item, press - 1\n \t\tremove upper item, press - 2\n \t\tshaw upper item, press - 3\n \t\tto exit, press - 4");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(new string('-', 40));

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

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Enter upper item");
                        var newItem = Console.ReadLine();
                        stack.Push(newItem);
                        break;

                    case 2:
                        Console.WriteLine("Remove upper item");
                        var removeItem = Console.ReadLine();
                        stack.Pop();
                        break;

                    case 3:
                        var header = stack.Peek();
                        Console.WriteLine($"Upper item: {header}");

                        break;

                    case 4:
                        Console.WriteLine("Do you want to exit y/n?");
                        string switch_on = Console.ReadLine();

                        switch (switch_on)
                        {
                            case "y":
                                Environment.Exit(0);
                                break;
                            case "n":
                                continue;
                            default:
                                Console.WriteLine("Repeat answer.");
                                continue;
                        }
                        break;

                    default:
                        Console.WriteLine("Not a correct input. Enter value at 1 to 4");
                        selection = 1;
                        continue;
                }
            }
            while (selection <= 4  );

            Console.ReadLine();
        }
    }
}

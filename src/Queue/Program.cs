using Queue.Model;
using System;
using System.Linq;

namespace StackBaseonLL
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<object>();
            int selection = 0;

            do
            {
                Console.WriteLine(new string('-', 44));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("If you want to: add upper item, press \t - 1\n \t\tremove lower item, press - 2\n \t\tshaw lower item, press \t - 3\n \t\tto exit, press \t\t - 4");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(new string('-', 44));

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
                        var enqueueItem = Console.ReadLine();
                        queue.Enqueue(enqueueItem);
                        break;

                    case 2:
                        var lowerItem = queue.Peek();
                        Console.WriteLine($"Removed lower {lowerItem} item");
                        queue.Dequeue();
                        break;

                    case 3:
                        var firstItem = queue.Peek();
                        Console.WriteLine($"Upper item: {firstItem}");
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

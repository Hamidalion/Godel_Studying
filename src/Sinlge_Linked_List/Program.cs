using Sinlge_Linked_List.Model;
using System;
using System.Linq;

namespace Sinlge_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<object>();

            int selection = 0;

            do
            {
                Console.WriteLine(new string('-', 40));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("If you want to: add item, press - 1\n \t\tremove item, press - 2\n \t\tshaw all, press - 3\n \t\tto exit, press - 4");
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
                        Console.WriteLine("Enter new item");
                        var newItem = Console.ReadLine();
                        list.Add(newItem);
                        break;

                    case 2:
                        Console.WriteLine("Enter item to Remove");
                        var removeItem = Console.ReadLine();
                        list.Remove(removeItem);
                        break;

                    case 3:
                        foreach (var item in list)
                        {
                            Console.WriteLine(item + ";");
                        }
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

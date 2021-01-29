using List.Model;
using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackArray = new SimgleList<int>();

            link1:
            Console.WriteLine("If you want to add new item, press - 1\nIf you want to remove item, press - 2\nIf you want to shaw to all, press - 3");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":

                    Console.WriteLine("Enter new item");
                    int newItem = Int32.Parse(Console.ReadLine());
                    stackArray.Push(newItem);

                    goto link1;
                    break;

                case "2":
                    Console.WriteLine("Enter item to Remove");
                    stackArray.Pop();

                    goto link1;
                    break;

                case "3":
                    Console.WriteLine($"Last item is");
                    stackArray.Peek();

                    goto link1;
                    break;

                default:
                    Console.WriteLine("Unknown operation");

                    goto link1;
                    break;
            }
        }
    }
}

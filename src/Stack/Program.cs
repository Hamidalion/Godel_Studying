using Stack.Model;
using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            var stackArray = new StackArray<int>();

            link1:
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("If you want to\n \t\tadd new item, press - 1\n \t\tremove item, press - 2\n \t\tshaw of last, press - 3");
            Console.WriteLine(new string('-', 40));
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
                    int removeItem = int.Parse(Console.ReadLine());

                    if (removeItem != stackArray.Peek())
                    {
                        Console.WriteLine($"You are write a wrong number. The last nuber is {stackArray.Peek()}");
                    }
                    else
                    {
                        stackArray.Pop();
                    }

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

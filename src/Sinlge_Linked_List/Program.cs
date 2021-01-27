using Sinlge_Linked_List.Model;
using System;

namespace Sinlge_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            link1:
            Console.WriteLine("If you want to add new item, press - 1\nIf you want to remove item, press - 2\nIf you want to shaw to all, press - 3");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":

                    Console.WriteLine("Enter new item");
                    int newItem = Int32.Parse(Console.ReadLine());
                    list.Add(newItem);

                    goto link1;
                    break;

                case "2":
                    Console.WriteLine("Enter item to Remove");
                    int removeItem = Int32.Parse(Console.ReadLine());
                    list.Remove(removeItem);

                    goto link1;
                    break;

                case "3":
                    Console.WriteLine("All item");
                    foreach (var item in list)
                    {
                        Console.WriteLine(item + " ");
                    }

                    goto link1;
                    break;

                default:
                    Console.WriteLine("Unknown operation");

                    goto link1;
                    break;
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;

namespace Sinlge_Linked_List.Model
{
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// First value.
        /// </summary>
        public Node<T> FirstValue { get; set; }

        /// <summary>
        /// Last value.
        /// </summary>
        public Node<T> LastValue { get; set; }

        /// <summary>
        /// Nomber of Nodes.
        /// </summary>
        public int NodeCount { get; set; }

        /// <summary>
        /// Empty constructor of LinkedList.
        /// </summary>
        public LinkedList()
        {
            FirstValue = null;
            LastValue = null;
            NodeCount = 0;
        }

        /// <summary>
        /// Overloading constructor whith data.
        /// </summary>
        /// <param name="data">Input data.</param>
        public LinkedList(T data)
        {
            SetFirstLastValue(data);
        }

        private void SetFirstLastValue(T data)
        {
            var node = new Node<T>(data);
            FirstValue = node;
            LastValue = node;
            NodeCount = 1;

            Console.WriteLine($"Set {node}");
        }

        public void Add(T data)
        {
            if (LastValue != null)
            {
                var node = new Node<T>(data);
                LastValue.Next = node;
                LastValue = node;
                Console.WriteLine($"Set {node}");
                NodeCount++;
            }
            else
            {
                SetFirstLastValue(data);
            }
        }

        public void Remove(T data)
        {
            if (FirstValue != null)
            {
                if (FirstValue.Data.Equals(data))
                {
                    FirstValue = FirstValue.Next;
                    NodeCount--;
                    Console.WriteLine($"Remove, {data}");

                    return;
                }

                var current = FirstValue.Next;
                var previous = FirstValue;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        NodeCount--;

                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = FirstValue;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}

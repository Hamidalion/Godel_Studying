using Queue.Resources;
using System;
using System.Collections;

namespace Queue.Model
{
    /// <summary>
    /// Linked List.
    /// </summary>
    /// <typeparam name="T">Data type.</typeparam>
    public class Queue<T> : IEnumerable
    {
        /// <summary>
        /// Upper value.
        /// </summary>
        Node<T> upperValue;

        /// <summary>
        /// Lower value.
        /// </summary>
        Node<T> lowerValue;

        /// <summary>
        /// Number of Nodes.
        /// </summary
        int count;

        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Empty value.
        /// </summary>
        public bool IsEmpty
        {
            get { return count == 0; }
        }

        /// <summary>
        /// Add upper value.
        /// </summary>
        /// <param name="item">Value.</param>
        public void Enqueue(T item)
        {
            Node<T> node = new Node<T>(item);

            Node<T> lowerNode = lowerValue;
            lowerValue = node;

            if (count == 0)
            {
                upperValue = lowerValue;
            }
            else
            {
                lowerNode.Next = lowerValue;
            }
            count++;
        }

        /// <summary>
        /// Remove lower value.
        /// </summary>
        /// <returns>Value.</returns>
        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException(Message.Empty);
            }
            T output = upperValue.Data;
            upperValue = upperValue.Next; 
            count--;

            return output;
        }

        /// <summary>
        /// Upper value.
        /// </summary>
        /// <returns>Value.</returns>
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException(Message.Empty);
            }

            return lowerValue.Data;
        }

        public IEnumerator GetEnumerator()
        {
            var current = upperValue;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}

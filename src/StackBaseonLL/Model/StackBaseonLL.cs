using StackBaseonLL.Resources;
using System;
using System.Collections;

namespace StackBaseonLL.Model
{
    /// <summary>
    /// Linked List.
    /// </summary>
    /// <typeparam name="T">Data type.</typeparam>
    public class NodeStack<T> : IEnumerable
    {
        /// <summary>
        /// Upper value.
        /// </summary>
        Node<T> upperValue;

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
        public void Push(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = upperValue; 
            upperValue = node;
            count++;
        }

        /// <summary>
        /// Remove upper value.
        /// </summary>
        /// <returns>Value.</returns>
        public T Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
            {
                throw new InvalidOperationException(Message.Empty);
            }

            Node<T> temp = upperValue;
            upperValue = upperValue.Next; // переустанавливаем верхушку стека на следующий элемент
            count--;

            return temp.Data;
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

            return upperValue.Data;
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

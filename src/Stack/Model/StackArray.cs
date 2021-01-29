using Stack.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack.Model
{
    public class StackArray<T>
    {
        private List<T> items = new List<T>();

        /// <summary>
        /// Property when satck is Empty.
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return items.Count == 0;
            }
        }

        /// <summary>
        /// Property of count satck.
        /// </summary>
        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        /// <summary>
        /// Add item.
        /// </summary>
        /// <param name="item">Item.</param>
        public void Push(T item)
        {
            items.Add(item);
        }

        /// <summary>
        /// See & remove item
        /// </summary>
        /// <returns>Last item.</returns>
        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);

                return item;
            }
            else
            {
                throw new NullReferenceException(ResourceMessage.Empty);
            }
        }

        /// <summary>
        /// See last item.
        /// </summary>
        /// <returns>Last item.</returns>
        public T Peek()
        {
            if (!IsEmpty)
            {
                Console.WriteLine(items.LastOrDefault());
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException(ResourceMessage.Empty);
            }
        }

        public override string ToString()
        {
            return Count + ResourceMessage.Stack;
        }
    }
}

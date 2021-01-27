namespace Sinlge_Linked_List.Model
{
    public class Node<T>
    {
        private T data = default(T);

        /// <summary>
        /// Property date of instace.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// An instance of the class stores next adress pf instance.
        /// </summary>
        public Node<T> Next { get; set; }

        /// <summary>
        /// Constructor of Node element.
        /// </summary>
        /// <param name="data">Value of Node.</param>
        public Node(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

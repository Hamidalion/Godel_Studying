namespace Queue.Model
{
    /// <summary>
    /// One node of Queue.
    /// </summary>
    /// <typeparam name="T">Data type.</typeparam>
    public class Node<T>
    {
        /// <summary>
        /// Property data of instace.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Constructor of Node element.
        /// </summary>
        /// <param name="data">Value of Node.</param>
        public Node(T data)
        {
            Data = data;
        }

        /// <summary>
        /// An instance of the class stores next address of instance.
        /// </summary>
        public Node<T> Next { get; set; }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

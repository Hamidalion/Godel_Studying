namespace StackBaseonLL.Model
{
    /// <summary>
    /// One node of Stack.
    /// </summary>
    /// <typeparam name="T">Data type.</typeparam>
    public class Node<T>
    {
        /// <summary>
        /// Property data of instace.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// An instance of the class stores next address of instance.
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

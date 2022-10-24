namespace ResizeArray
{
    class Node<T>
    {
        public int Size { get; private set; }
        public Node<T> Nextel;
        public T[] Val;
        public Node(int Size)
        {
            Val = new T[Size];
            this.Size = Size;
            Nextel = null;
        }
    }
}
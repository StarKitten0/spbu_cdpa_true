using System;

namespace ResizeArray
{
    public class ResizeArray<T>
    {
        private const int def_size = 10;
        private int capacity;
        public int Count { get; private set; }

        private Node<T> head;
        public ResizeArray()
        {
            head = new Node<T>(def_size);
            Count = 0;
            capacity = def_size;
        }

        public T this[int index] { get { return getItem(index); } set { getItem(index) = value; } }

        public void Append(T value)
        {
            Count++;
            if (Count > capacity)
            {
                Node<T> temp = head;
                while (temp.Nextel != null)
                    temp = temp.Nextel;
                temp.Nextel = new Node<T>(def_size);
                capacity += def_size;
            }
            this[Count - 1] = value;
        }

        private ref T getItem(int index)
        {
            if (index >= Count)
                throw new IndexOutOfRangeException();
            int i = 0;
            Node<T> temp = head;
            while (i != index / def_size)
            {
                i++;
                temp = temp.Nextel;
            }
            return ref temp.Val[index % def_size];
        }
    }
}

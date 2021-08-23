using System;

namespace LinkedStack
{
    public class Node<T> : INode<T>
    {
        public T Data { get; set; }
        public INode<T> Next { get; set; }
        public INode<T> Prev { get; set; }

        public Node()
        {
            Data = default;
            Next = Prev = null;
        }

        public Node( T element )
        {
            Data = element;
            Next = Prev = null;
        }

        public INode<T> Create( T element )
        {
            try
            {
                return new Node<T>
                {
                    Data = element,
                    Next = null,
                    Prev = null
                };

            }
            catch (Exception)
            {
                throw new Exception( "There seems to be not enough memory" );
            }
        }

        public void Display()
        {
            Console.Write( Data );

            Console.Write( Next != null ? " -> " : "\n" );
        }

        public int Compare( INode<T> node )
        {
            IComparable comparable = (IComparable) Data;

            return comparable.CompareTo( node.Data );
        }
    }

    public interface INode<T>
    {
        public T Data { get; set; }
        public INode<T> Next { get; set; }
        public INode<T> Prev { get; set; }
        INode<T> Create( T element );
        void Display();
        int Compare( INode<T> node );
    }
}

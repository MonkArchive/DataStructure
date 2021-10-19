using System;

namespace LinkedQueue
{
    public class LinkedQueue<T> : IQueue<T>
    {
        private INode<T> front = null;
        private INode<T> rear = null;

        public LinkedQueue()
        {
            front = rear = null;
        }

        public void Add( T item )
        {
            INode<T> node = new Node<T>(item);

            if (front == null) // Queue Is Empty
                front = rear = node;
            else
            {
                rear.Next = node;
                rear = node;
            }
        }

        public void Clear()
        {
            INode<T> node = front;

            while (node != null)
            {
                front = front.Next;
                node.Next = null;
                node = front;
            }
        }

        public int Count()
        {
            int count = 0;

            INode<T> node = front;

            while (node != null)
            {
                ++count;
                node = node.Next;
            }

            return count;
        }

        public bool IsEmpty()
        {
            return (front == null);
        }

        public bool IsFull()
        {
            return false;
        }

        public T Peek()
        {
            if (front == null)
                throw new Exception( "Queue Is empty" );

            return front.Data;
        }

        public T Remove()
        {
            if (front == null)
                throw new Exception( "Queue Is empty" );

            INode<T> node = front;

            front = front.Next;
            node.Next = null;

            if (front == null)
                rear = null;

            return node.Data;
        }
    }

    public interface IQueue<T>
    {
        void Add( T item );
        T Remove();
        void Clear();
        bool IsEmpty();
        bool IsFull();
        int Count();
        T Peek();
    }
}

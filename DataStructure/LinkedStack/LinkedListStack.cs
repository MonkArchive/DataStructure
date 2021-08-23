using System;

namespace LinkedStack
{
    public class LinkedListStack<T> : IStack<T>
    {
        private INode<T> top = null;

        public LinkedListStack()
        {
            top = null;
        }

        public void Clear()
        {
            INode<T> node = top;

            while (node != null)
            {
                top = top.Next;
                node.Next = null;
                node = top;
            }
        }

        public int Count()
        {
            int count = 0;

            INode<T> node = top;

            while (node != null)
            {
                ++count;
                node = node.Next;
            }

            return count;
        }

        public bool IsEmpty()
        {
            return (top == null);
        }

        public bool IsFull()
        {
            return false;
        }

        public T Peek()
        {
            if (top == null)
                throw new Exception( "Stack Is empty" );

            return top.Data;
        }

        public T Pop()
        {
            if (top == null)
                throw new Exception( "Stack Is empty" );

            INode<T> node = top;

            top = top.Next;
            node.Next = null;

            return node.Data;
        }

        public void Push( T item )
        {
            INode<T> node = new Node<T>(item);

            node.Next = top;
            top = node;
        }
    }

    public interface IStack<T>
    {
        void Push( T item );
        T Pop();
        bool IsFull();
        bool IsEmpty();
        int Count();
        void Clear();
        T Peek();
    }
}

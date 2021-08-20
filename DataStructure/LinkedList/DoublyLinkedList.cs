using System.Collections.Generic;
using System.Globalization;

namespace LinkedList
{
    public class DoublyLinkedList<T> : ILinkedList<T>
    {
        private INode<T> head = null;

        public DoublyLinkedList()
        {
            head = null;
        }

        public void Append( INode<T> node )
        {
            if (head == null)
                head = node;
            else
            {
                INode<T> p = head;

                while (p.Next != null)
                    p = p.Next;

                p.Next = node;
                node.Prev = p;
            }
        }

        public bool ContainsCycles()
        {
            throw new System.NotImplementedException();
        }

        public void Display()
        {
            INode<T> node = head;

            while (node != null)
            {
                node.Display();
                node = node.Next;
            }
        }

        public void InsertAfter( INode<T> node, INode<T> newNode )
        {
            newNode.Next = node.Next;
            newNode.Prev = node;
            node.Next = newNode;

            if (newNode.Next != null)
                newNode.Next.Prev = newNode;
        }

        public void InsertBefore( INode<T> node, INode<T> newNode )
        {
            newNode.Next = node;
            newNode.Prev = node.Prev;
            node.Prev = newNode;

            if (newNode.Prev != null)
                newNode.Prev.Next = newNode;
            else
                head = newNode;
        }

        public bool IsEmpty()
        {
            return (head == null);
        }

        public void Prepend( INode<T> node )
        {
            node.Next = head;
            head.Prev = node;
            head = node;
        }

        public INode<T> Remove( INode<T> node )
        {
            if (node.Prev != null)
                node.Prev.Next = node.Next;

            if (node.Next != null)
                node.Next.Prev = node.Prev;

            if (node == head)
                head = node.Next;

            return node;
        }

        public INode<T> Search( T element )
        {
            INode<T> node = head;

            while ((node != null) && (!EqualityComparer<T>.Default.Equals( node.Data, element )))
                node = node.Next;

            return node;
        }
    }
}

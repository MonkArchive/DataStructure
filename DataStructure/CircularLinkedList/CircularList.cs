using System.Collections.Generic;
using System;

namespace CircularLinkedList
{
    public class CircularList<T> : ILinkedList<T>
    {
        private INode<T> tail = null;

        public CircularList()
        {
            tail = null;
        }

        public void Append( INode<T> node )
        {
            // It is Empty
            if (tail == null)
            {
                node.Next = node;
                tail = node;
            }
            else
            {
                node.Next = tail.Next;
                tail.Next = node;
                tail = node;
            }
        }

        public void Clear()
        {
            //while (tail != null)
            //    Remove( tail );

            // Make It A Linear Linked List
            INode<T> node = tail.Next;
            tail.Next = null;
            tail = node;

            while (node != null)
            {
                tail = tail.Next;
                node.Next = null;
                node = tail;
            }
        }

        public long Count()
        {
            long count = 0;

            if (tail != null)
            {
                INode<T> node = tail ;

                do
                {
                    ++count;
                    node = node.Next;

                } while (node != tail);
            }

            return count;
        }

        public void Display()
        {
            if (tail != null)
            {
                INode<T> node = tail ;

                do
                {
                    node = node.Next;

                    node.Display();

                    Console.Write( " -> " );

                } while (node != tail);

                Console.WriteLine( "NULL \n" );
            }
        }

        public void InsertAfter( INode<T> node, INode<T> newNode )
        {
            newNode.Next = node.Next;
            node.Next = newNode;

            if (tail == node)
                tail = newNode;
        }

        public void InsertBefore( INode<T> node, INode<T> newNode )
        {
            INode<T> p = tail ;

            // Assumption: node is present in the linked list
            while (p.Next != node)
                p = p.Next;

            newNode.Next = node;
            p.Next = newNode;
        }

        public bool IsEmpty()
        {
            return tail == null;
        }

        public void Prepend( INode<T> node )
        {
            // It is Empty
            if (tail == null)
            {
                node.Next = node;
                tail = node;
            }
            else
            {
                node.Next = tail.Next;
                tail.Next = node;
                // tail = node;
            }
        }

        public INode<T> Remove( INode<T> node )
        {
            INode<T> p = tail ;

            // Assumption: node is present in the linked list
            while (p.Next != node)
                p = p.Next;

            // Deleting Last Node
            if ((node == tail) && (tail.Next == tail))
                tail = null;
            else
            {
                p.Next = node.Next;

                if (node == tail)
                    tail = p;
            }

            node.Next = null;
            return node;
        }

        public INode<T> Search( T element )
        {
            INode<T> node = tail ;
            bool isFound = false;

            if (tail != null)
            {
                do
                {
                    node = node.Next;

                    if (EqualityComparer<T>.Default.Equals( node.Data, element ))
                    {
                        isFound = true;
                        break;
                    }

                } while (node != tail);
            }

            return isFound ? node : null;
        }
    }
}

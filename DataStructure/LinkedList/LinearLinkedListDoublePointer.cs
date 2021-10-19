using System.Collections.Generic;

namespace LinkedList
{
    public class LinearLinkedListDoublePointer<T> : ILinkedList<T>
    {
        private INode<T> head = null;
        private INode<T> tail = null;

        public LinearLinkedListDoublePointer()
        {
            head = tail = null;
        }

        public void Append( INode<T> node )
        {
            if (head == null)
                head = tail = node;
            else
            {
                tail.Next = node;
                tail = node;
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
            node.Next = newNode;

            if (tail == node)
                tail = newNode;
        }

        public void InsertBefore( INode<T> node, INode<T> newNode )
        {
            if (head == node)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                INode<T> p = head;

                while (p.Next != node)
                    p = p.Next;
                newNode.Next = node;
                p.Next = newNode;
            }
        }

        public bool IsEmpty()
        {
            return (head == null);
        }

        public void Prepend( INode<T> node )
        {
            node.Next = head;
            head = node;

            if (tail == null)
                tail = node;
        }

        public INode<T> Remove( INode<T> node )
        {
           if (head == node)
            {
                head = head.Next;
                if (tail == node)
                    tail = null;
            }
           else
            {
                INode<T> p = head;

                while (p.Next != node)
                    p = p.Next;

                p.Next = node.Next;

                if (node == tail)
                    tail = p;
            }

            return node;
        }

        public virtual INode<T> Search( T element )
        {
            INode<T> node = head;

            while ((node != null) && (!EqualityComparer<T>.Default.Equals( node.Data, element )))
                node = node.Next;

            return node;
        }

    }
}

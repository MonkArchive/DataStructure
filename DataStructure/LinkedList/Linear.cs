using System.Collections.Generic;
using System.Xml.Linq;

namespace LinkedList
{
    public class LinearLinkedListSinglePointer<T> : ILinkedList<T>
    {
        private INode<T> head = null;

        public LinearLinkedListSinglePointer()
        {
            head = null;
        }

        public virtual void Append( INode<T> node )
        {
            if (head == null)
                head = node;
            else
            {
                INode<T> p = head;

                while (p.Next != null)
                    p = p.Next;

                p.Next = node;
            }
        }

        public virtual void BubbleSort()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Clear()
        {
            INode<T> node = head;

            while (node != null)
            {
                head = head.Next;
                node.Next = null;
                node = head;
            }
        }

        public virtual bool ContainsCycles()
        {
            throw new System.NotImplementedException();
        }

        public virtual long Count()
        {
            int count = 0;

            INode<T> node = head;

            while (node != null)
            {
                ++count;
                node = node.Next;
            }

            return count;
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

        public virtual void InsertAfter( INode<T> node, INode<T> newNode )
        {
            newNode.Next = node.Next;
            node.Next = newNode;
        }

        public virtual void InsertBefore( INode<T> node, INode<T> newNode )
        {
            if (node == head)
            {
                newNode.Next = node;
                head = newNode;
            }
            else
            {
                // Get P Point to node before 'node'
                var p = head;

                while (p.Next != node)
                    p = p.Next;

                InsertAfter( p, newNode );
            }
        }

        public virtual void InsertionSort()
        {
            throw new System.NotImplementedException();
        }

        public virtual bool IsEmpty()
        {
            return (head == null);
        }

        public virtual void MergeSort()
        {
            throw new System.NotImplementedException();
        }

        public void Prepend( INode<T> node )
        {
            node.Next = head;
            head = node;
        }

        public virtual void Remove( INode<T> node )
        {
            if (head == node)
                head = head.Next;
            else
            {
                // Get P Point to node before 'node'
                var p = head;

                while (p.Next != node)
                    p = p.Next;

                p.Next = node.Next;
            }
        }

        public virtual void RemoveDuplicates()
        {
            var p = head;

            while (p != null)
            {
                var q = p.Next;

                while (q != null)
                {
                    if (EqualityComparer<T>.Default.Equals( q.Data, p.Data ))
                    {
                        var temp = q;
                        q = q.Next;
                        Remove( temp );
                    }
                    else
                        q = q.Next;
                }

                // Go To Next Node
                p = p.Next;
            }
        }

        public virtual void Reverse()
        {
            if (head != null)
            {
                // Make p, q Point To The Node After Head
                var p = head.Next;

                // Make Head A Single Node
                head.Next = null;

                while (p != null)
                {
                    var q = p.Next;
                    p.Next = head;
                    head = p;
                    p = q;
                }
            }
        }

        public virtual INode<T> Search( T element )
        {
            INode<T> node = head;

            while ((node != null) && (!EqualityComparer<T>.Default.Equals( node.Data, element )))
                node = node.Next;

            return node;
        }

        public virtual void SelectionSort()
        {
            throw new System.NotImplementedException();
        }
    }

    public interface ILinkedList<T>
    {
        void Append( INode<T> node );
        INode<T> Search( T element );
        void Remove( INode<T> node );
        void Clear();
        long Count();
        bool IsEmpty();
        void InsertAfter( INode<T> node, INode<T> newNode );
        void InsertBefore( INode<T> node, INode<T> newNode );
        void BubbleSort();
        void InsertionSort();
        void SelectionSort();
        void MergeSort();
        void RemoveDuplicates();
        void Reverse();
        bool ContainsCycles();
        void Display();
        void Prepend( INode<T> node );
    }
}

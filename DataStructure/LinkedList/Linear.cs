using System.Collections.Generic;
using System.Drawing;
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

        public virtual void InsertionSort()
        {
            INode<T> p = head;

            head = null;

            while (p != null)
            {
                INode<T> q = p;

                p = p.Next;
                q.Next = null;      // There Is No Need To Do This, But A Better Approach

                InsertSorted( q );
            }
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

        INode<T> ILinkedList<T>.Remove( INode<T> node )
        {
            throw new System.NotImplementedException();
        }

        public virtual void RemoveDuplicates()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Reverse()
        {
            throw new System.NotImplementedException();
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
            INode<T> p = head;

            while (p!= null)
            {
                INode<T> q = p.Next;    // Start At The Behinning Of Remaining List
                INode<T> m = p;         // Assume This Is The Smallest Node

                // Find The Node Having The Smallest Value
                while (q != null)
                {
                    if (q.Compare( m ) < 0)
                        m = q;
                    q = q.Next;
                }

                if (p != m)
                {
                    // Swap Values Of m & p
                    T temp = p.Data;
                    p.Data = m.Data;
                    m.Data = temp;
                }

                // Reduce The List Further
                p = p.Next;
            }
        }

        public bool IsSorted( bool DescendingOrder = false )
        {
            if (head != null)
            {
                INode<T> node = head;

                if (DescendingOrder)
                    while ((node.Next != null) && (node.Compare( node.Next ) >= 0))
                        node = node.Next;
                else
                    while ((node.Next != null) && (node.Compare( node.Next ) <= 0))
                        node = node.Next;

                // 1. List is sorted => node.Next == null
                // 2. List is unsorted => node.Next != null

                return (node.Next == null);
            }

            return true;
        }

        public void InsertSorted( INode<T> newNode )
        {
            if (head == null)
            {
                head = newNode;
            }
            else if (head.Compare( newNode ) >= 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                INode<T> node = head;

                while ((node.Next != null) && (node.Next.Compare( newNode ) < 0))
                    node = node.Next;

                newNode.Next = node.Next;
                node.Next = newNode;
            }
        }

        public INode<T> SplitAlternateNode()
        {
            INode<T> head1 = null, tail1=null;
            INode<T> head2 = null, tail2=null;
            INode<T> p;

            while (head != null)
            {
                p = GetFirstNode();

                // Add p To First Linked List
                AppendAtEnd( ref head1, ref tail1, p );

                if (head != null)
                {
                    p = GetFirstNode();

                    // Add p to Second Linked List
                    AppendAtEnd( ref head2, ref tail2, p );
                }
            }

            // Before Leaving The Method
            head = head1;
            return head2;
        }

        private INode<T> GetFirstNode()
        {
            INode<T> p = head;
            head = head.Next;
            p.Next = null;
            return p;
        }

        private static void AppendAtEnd( ref INode<T> head, ref INode<T> tail, INode<T> p )
        {
            if (head == null)
                head = tail = p;
            else
            {
                tail.Next = p;
                tail = p;
            }
        }

        public INode<T> SplitInTheMiddle()
        {
            throw new System.NotImplementedException();
        }
    }

    public interface ILinkedList<T>
    {
        void Append( INode<T> node );
        INode<T> Search( T element );
        INode<T> Remove( INode<T> node );
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
        bool IsSorted( bool DescendingOrder = false );
        void InsertSorted( INode<T> newNode );      // Assumption: List Is In Ascending Order
        INode<T> SplitAlternateNode();
        INode<T> SplitInTheMiddle();
    }
}


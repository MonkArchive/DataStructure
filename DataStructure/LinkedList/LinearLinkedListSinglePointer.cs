using System.Collections.Generic;
using System.Drawing;
using System.Net.Security;
using System.Xml.Linq;

namespace LinkedList
{
    public class LinearLinkedListSinglePointer<T> : ILinkedList<T>
    {
        private INode<T> head = null;

        #region Miscellaneous
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

        public virtual bool IsEmpty()
        {
            return (head == null);
        }

        public virtual void Prepend( INode<T> node )
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

        #endregion

        #region BubbleSort

        public virtual void BubbleSort()
        {
            if (head != null)
            {
                bool isSwapped = true;

                while (isSwapped)
                {
                    INode<T> node = head;

                    isSwapped = false;

                    while (node.Next != null)
                    {
                        if (node.Compare( node.Next ) > 0)
                        {
                            T data = node.Data;
                            node.Data = node.Next.Data;
                            node.Next.Data = data;
                            isSwapped = true;
                        }

                        node = node.Next;
                    }
                }
            }
        }

        #endregion

        public virtual bool ContainsCycles()
        {
            throw new System.NotImplementedException();
        }

        #region InsertionSort

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

        #endregion

        #region MergeSort

        public virtual void MergeSort()
        {
            MergeSort( ref head );
        }

        public INode<T> SplitInTheMiddle()
        {
            INode<T> p = head, q = null;

            if ((p != null) && (p.Next != null))
            {
                q = p.Next;

                while (q != null)
                {
                    p = p.Next;

                    q = q.Next;

                    if (q != null)
                        q = q.Next;
                }

                q = p.Next;
                p.Next = null;
            }

            return q;
        }


        public void Merge( LinearLinkedListSinglePointer<T> another )
        {
            INode<T> head3 = null, tail = null ;
            INode<T> p;

            while ((this.head != null) && (another.head != null))        // this.head -> head1; another.head -> head2
            {
                if (this.head.Compare( another.head ) < 0)            // this.head.data < another.head.data
                {
                    p = this.head;
                    this.head = this.head.Next;

                }
                else // this.head.data >= another.head.data
                {
                    p = another.head;
                    another.head = another.head.Next;
                }

                p.Next = null;
                AppendAtEnd( ref head3, ref tail, p );
            }

            // Either this.head == null || another.head == null
            if (this.head == null)
                tail.Next = another.head;
            else
                tail.Next = this.head;

            head = head3;
        }

        private void MergeSort(ref INode<T> head)
        {
            // Check If There Is No Node Or Just One Node
            if ((head != null) && (head.Next != null))
            {
                INode<T> head1;

                Split( ref head, out head1 );
                MergeSort( ref head );
                MergeSort( ref head1 );
                head = Merge( ref head, ref head1 );
            }
        }

        private void Split( ref INode<T> one, out INode<T> another )
        {
            INode<T> p = one, q = null;

            if ((p != null) && (p.Next != null))
            {
                q = p.Next;

                while ((q != null) && (q.Next != null))
                {
                    p = p.Next;

                    q = q.Next;

                    if (q != null)
                        q = q.Next;
                }

                q = p.Next;
                p.Next = null;
            }

            another = q;
        }

        private INode<T> Merge( ref INode<T> one, ref INode<T> another )
        {
            INode<T> head3 = null, tail = null ;
            INode<T> p;

            while ((one != null) && (another != null))
            {
                if (one.Compare( another ) < 0)
                {
                    p = one;
                    one = one.Next;

                }
                else
                {
                    p = another;
                    another = another.Next;
                }

                p.Next = null;
                AppendAtEnd( ref head3, ref tail, p );
            }

            tail.Next = one == null ? another : one;

            return head3;
        }

        #endregion

        #region SelectionSort

        public virtual void SelectionSort()
        {
            INode<T> p = head;

            while (p != null)
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

        #endregion
    }
}


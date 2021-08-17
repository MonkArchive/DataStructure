namespace LinkedList
{
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


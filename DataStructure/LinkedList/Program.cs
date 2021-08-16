using System;

namespace LinkedList
{
    class Program
    {
        static void Main( string[] args )
        {
            ILinkedList<int> list = new LinearLinkedListSinglePointer<int>();

            list.Prepend( new Node<int>( 30 ) );
            list.Prepend( new Node<int>( 3 ) );
            list.Append( new Node<int>( 7 ) );
            list.Append( new Node<int>( 20 ) );
            list.Append( new Node<int>( 10 ) );

            list.SelectionSort();
        }
    }
}

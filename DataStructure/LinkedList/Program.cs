using System;

namespace LinkedList
{
    class Program
    {
        static void Main( string[] args )
        {
            LinearLinkedListSinglePointer<int> list = new LinearLinkedListSinglePointer<int>();
            LinearLinkedListSinglePointer<int> another = new LinearLinkedListSinglePointer<int>();

            list.Append( new Node<int>( 25 ) );
            list.Append( new Node<int>( 21 ) );
            list.Append( new Node<int>( 15 ) );
            list.Append( new Node<int>( 13 ) );
            list.Append( new Node<int>( 5 ) );
            list.Append( new Node<int>( 6 ) );

            list.BubbleSort( );
        }
    }
}

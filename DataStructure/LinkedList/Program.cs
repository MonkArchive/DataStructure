using System;

namespace LinkedList
{
    class Program
    {
        static void Main( string[] args )
        {
            ILinkedList<int> list = new LinearLinkedListSinglePointer<int>();

            list.Prepend( new Node<int>( 3 ) );
            list.Prepend( new Node<int>( 7 ) );
            list.Append( new Node<int>( 10 ) );
            list.Append( new Node<int>( 20 ) );
            list.Append( new Node<int>( 30 ) );

            list.InsertAfter( list.Search( 20 ), new Node<int>(25) );
            list.InsertAfter( list.Search( 30 ), new Node<int>( 35 ) );
            list.InsertBefore( list.Search( 20 ), new Node<int>( 15 ) );
            list.InsertBefore( list.Search( 3 ), new Node<int>( 1 ) );

            Console.WriteLine( $"There are {list.Count()} Nodes In The List" );

            list.Display();

            list.Remove( list.Search( 20 ));
            list.Clear();
        }
    }
}

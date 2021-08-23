using System;

namespace CircularLinkedList
{
    class Program
    {
        static void Main( string[] args )
        {
            ILinkedList<int> list = new CircularList<int>();

            list.Append( new Node<int>( 10 ) );
            list.Append( new Node<int>( 20 ) );
            list.Append( new Node<int>( 30 ) );
            list.Prepend( new Node<int>( 40 ) );

            list.Remove( list.Search( 10 ) );
            list.Remove( list.Search( 30 ) );
            list.Remove( list.Search( 40 ) );
            list.Remove( list.Search( 20 ) );
        }
    }
}

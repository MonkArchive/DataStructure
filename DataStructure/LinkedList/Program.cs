using System;

namespace LinkedList
{
    class Program
    {
        static void Main( string[] args )
        {
            LinearLinkedListSinglePointer<int> list = new LinearLinkedListSinglePointer<int>();
            LinearLinkedListSinglePointer<int> another = new LinearLinkedListSinglePointer<int>();

            list.Append( new Node<int>( 7 ) );
            list.Append( new Node<int>( 10 ) );
            list.Append( new Node<int>( 20 ) );
            list.Append( new Node<int>( 25 ) );

            another.Append( new Node<int>( 3 ) );
            another.Append( new Node<int>( 6 ) );
            another.Append( new Node<int>( 12 ) );
            another.Append( new Node<int>( 15 ) );

            list.Merge( another );
        }
    }
}

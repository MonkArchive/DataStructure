using System;

namespace LinkedList
{
    class Program
    {
        static void Main( string[] args )
        {
            ILinkedList<int> list = new LinearLinkedListDoublePointer<int>();

            list.Append( new Node<int>( 25 ) );
            list.Append( new Node<int>( 21 ) );
            list.Prepend( new Node<int>( 15 ) );
            list.Prepend( new Node<int>( 13 ) );
            list.Append( new Node<int>( 5 ) );
            list.Append( new Node<int>( 6 ) );

            list.Remove( list.Search( 13 ) );
            list.Remove( list.Search( 6 ) );

            list.Display();
        }

        //static void Towers( char source, char dest, char temp, int disks )
        //{
        //    if (disks > 0)
        //    {
        //        // Move N-1 Disks From Source To Temporary Using Dest As Temporary
        //        Towers( source, temp, dest, disks - 1 );

        //        // It Means There Is Only 1 Disk Left On Source
        //        Console.WriteLine($"Move Disk From {source} To {dest}");

        //        // Move N-1 Disks From Temporary To Dest Using Source As Temporary
        //        Towers( temp, dest, source, disks - 1 );
        //    }
        //}
    }
}

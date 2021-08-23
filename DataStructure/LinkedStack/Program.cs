using System;

namespace LinkedStack
{
    class Program
    {
        static void Main( string[] args )
        {
            IStack<int> s = new LinkedListStack<int>();

            s.Push( 1 );
            s.Push( 2 );
            s.Push( 3 );

            Console.WriteLine( s.Count() );

            Console.WriteLine( s.Pop() );
            Console.WriteLine( s.Pop() );
            Console.WriteLine( s.Pop() );
        }
    }
}

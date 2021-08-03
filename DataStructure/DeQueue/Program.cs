using System;

namespace DeQueue
{
    class Program
    {
        static void Main( string[] args )
        {
            IDeQue<int> deQue = new DeQue<int>(5);

            deQue.AddAtFront( 1 );
            deQue.AddAtRear( 2 );
            deQue.AddAtFront( 3 );

            Console.WriteLine( deQue.RemoveFromFront() );
            Console.WriteLine( deQue.RemoveFromRear() );
            Console.WriteLine( deQue.RemoveFromRear() );

            deQue.AddAtFront( 4 );
            deQue.AddAtFront( 5 );
            deQue.AddAtFront( 1 );
            deQue.AddAtFront( 2 );

            while (!deQue.IsEmpty())
                Console.WriteLine( deQue.RemoveFromRear() );
        }
    }
}

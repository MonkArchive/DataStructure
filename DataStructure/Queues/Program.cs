using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> queue = new EmptyLocationQueue<int>(5);

            queue.Add(1);
            queue.Add(2);
            queue.Add(3);

            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());

            queue.Add(4);
            queue.Add(5);
            queue.Add(1);
            queue.Add(2);
            queue.Add( 4 );
            queue.Add( 5 );

            while (!queue.IsEmpty())
                Console.WriteLine(queue.Remove());
        }
    }
}

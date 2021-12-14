using System;

namespace Heap;

class Program
{
    static void Main(string[] args)
    {
        PriorityQueue queue = new PriorityQueue(20);

        queue.AddQ(10);
        queue.AddQ(20);
        queue.AddQ(25);
        queue.AddQ(15);
        queue.AddQ(35);
        queue.AddQ(21);

        Console.WriteLine(queue.RemoveQ());
        Console.WriteLine(queue.RemoveQ());

        queue.AddQ(45);
        queue.AddQ(55);

        while (!queue.IsEmpty())
            Console.WriteLine(queue.RemoveQ());

        //Heap heap = new Heap(20);

        //heap.Add(10);
        //heap.Add(20);
        //heap.Add(25);
        //heap.Add(15);
        //heap.Add(35);
        //heap.Add(21);

        //heap.Sort(heap.Size());
    }
}

using System;

namespace Heap;

class Program
{
    static void Main(string[] args)
    {
        Heap heap = new Heap(20);

        heap.Insert(10);
        heap.Insert(20);
        heap.Insert(25);
        heap.Insert(15);
        heap.Insert(35);
        heap.Insert(21);
    }
}

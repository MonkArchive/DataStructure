namespace Heap;

public class PriorityQueue
{
    private Heap queue;

    public PriorityQueue(int maxSize)
    {
        queue = new Heap(maxSize);
    }

    public bool IsEmpty()
    {
        return queue.IsEmpty();
    }

    public void Clear()
    {
        queue.ClearHeap();
    }

    public void AddQ(int item)
    {
        queue.Insert(item);
    }

    public int RemoveQ()
    {
        return queue.DeleteMax();
    }

    public int Size()
    {
        return queue.Size();
    }
}

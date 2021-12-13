namespace Heap;

public class Heap : IHeap
{
    int[] _list;
    int _totalElements;
    int _max;

    public Heap(int maxSize)
    {
        _max = maxSize;
        _list = new int[maxSize];
        _totalElements = 0;
    }

    /// <summary>
    /// Returns The Index Of The Left Child Of The Node At Index
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    private int LeftChildIndex(int index)
    {
        if (2 * index + 1 > _totalElements)
            return -1;
        else
            return 2 * index + 1;
    }

    int RightChildIndex(int index)
    {
        if (2 * index + 1 > _totalElements)
            return -1;
        else
            return 2 * index + 2;
    }

    int ParentIndex(int index)
    {
        if (index == 0)
            return -1;
        else
            return (index - 1) / 2;
    }

    public void CreateHeap()
    {
        _list = new int[_max];
        _totalElements = 0;
    }

    public void ClearHeap()
    {
        CreateHeap();
    }

    public int DeleteMax()
    {
        throw new NotImplementedException();
    }

    public int FindMax()
    {
        throw new NotImplementedException();
    }

    public void Heapify(int index)
    {
        int leftChildIndex = 2 * index + 1;
        int rightChildIndex = 2 * index + 2;
        int largest = index;

        // Here Comparing Left Child With The Parent Node
        if ((leftChildIndex <= _totalElements) && (_list[leftChildIndex] > _list[largest]))
            largest = leftChildIndex;

        // Here Comparing Right Child With The Greater Of The Parent An Left Child
        if ((rightChildIndex <= _totalElements) && (_list[rightChildIndex] > _list[largest]))
            largest = rightChildIndex;

        // If largest == index, It is Already A MaxHeap. Else We Need To Heapify 'this' and the subsequent Subtree
        if (largest != index)
        {
            swap(ref _list[index], ref _list[largest]);

            Heapify(largest);
        }
    }

    private void swap(ref int v1, ref int v2)
    {
        int v = v1;
        v1 = v2;
        v2 = v;
    }

    public void Insert(int item)
    {
        if (_totalElements == _max)
            throw new Exception($"Heap Elements Can't Exceed {_max}");

        _list[_totalElements++] = item;

        SiftUp(0, _totalElements - 1);
    }

    public bool IsEmpty()
    {
        return _totalElements == 0;
    }

    public int Replace(int newRoot)
    {
        throw new NotImplementedException();
    }

    public int Search(int item)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Moves A New Node Into Its Proper Position In The Heap
    /// </summary>
    /// <param name="startIndex">How High I Can Go</param>
    /// <param name="endIndex">Starting Index</param>
    public void SiftUp(int startIndex, int endIndex)
    {
        int childIndex = endIndex;

        while (childIndex > startIndex)
        {
            int parentIndex = ParentIndex(childIndex);

            if (_list[childIndex] > _list[parentIndex])
                swap (ref _list[childIndex], ref _list[parentIndex]);

            childIndex = parentIndex;
        }
    }

    public int Size()
    {
        return _totalElements;
    }

    public void Sort()
    {
        throw new NotImplementedException();
    }
}

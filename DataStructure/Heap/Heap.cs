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
        int oldRoot = _list[0];

        // Move Last Element To Root
        _list[0] = _list[_totalElements - 1];

        // Reduce The Size Of Heap By 1
        _totalElements--;

        // Rebuild The Heap
        Heapify(_totalElements - 1);

        // Return Max
        return oldRoot;
    }

    public int FindMax()
    {
        return _list[0];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index">The Index UpTo Which We Want To Heapify</param>
    public void Heapify(int index)
    {
        int lastIndex = 0;

        while (lastIndex <= index)
        {
            SiftUp(0, lastIndex);

            lastIndex++;
        }
    }

    private void swap(ref int v1, ref int v2)
    {
        int v = v1;
        v1 = v2;
        v2 = v;
    }

    /// <summary>
    /// Inserts The Element At The End Of The Heap And Maintains Heap Order
    /// </summary>
    /// <param name="item"></param>
    /// <exception cref="Exception"></exception>
    public void Insert(int item)
    {
        if (_totalElements == _max)
            throw new Exception($"Heap Elements Can't Exceed {_max}");

        _list[_totalElements++] = item;

        SiftUp(0, _totalElements - 1);
    }

    /// <summary>
    /// Inserts The Element At The End And DOESN'T Main The Heap Order
    /// </summary>
    /// <param name="item"></param>
    public void Add(int item)
    {
        if (_totalElements == _max)
            throw new Exception($"Heap Elements Can't Exceed {_max}");

        _list[_totalElements++] = item;
    }

    public bool IsEmpty()
    {
        return _totalElements == 0;
    }

    /// <summary>
    /// Replace The Existing Root With newRoot
    /// </summary>
    /// <param name="newRoot"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int Replace(int newRoot)
    {
        int oldRoot = _list[0];

        _list[0] = newRoot;
        Heapify(_totalElements - 1);

        return oldRoot;
    }

    public int Search(int item)
    {
        for (int i = 0; i < _totalElements; i++)
            if (_list[i] == item)
                return i;

        return -1;
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
                swap(ref _list[childIndex], ref _list[parentIndex]);

            childIndex = parentIndex;
        }
    }

    public int Size()
    {
        return _totalElements;
    }

    /// <summary>
    /// Assuming we Are Given An Unordered Array (NO HEAP)
    /// </summary>
    /// <param name="nElements">Total Number Of Elements To Be Sorted</param>
    public void Sort(int nElements)
    {
        int lastIndex = nElements - 1;

        while (lastIndex > 0)
        {
            // Build The Heap, Max Is At The Root
            Heapify(lastIndex);

            // Swap Root & Last Element
            swap (ref _list[0], ref _list[lastIndex]);

            lastIndex--;
        }
    }
}

namespace Heap;

public interface IHeap
{
    int FindMax();
    void Insert(int item);
    int DeleteMax();
    int Replace(int newRoot);

    void CreateHeap();
    void ClearHeap();
    void Heapify(int index);
    int Size();
    bool IsEmpty();
    void SiftUp(int startIndex, int endIndex);
    int Search(int item);
    void Sort();
}

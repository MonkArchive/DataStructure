using System;

namespace Sorting
{
    public class ArrayList : IArrayList
    {
        int[] list;
        int size;

        public ArrayList(int size)
        {
            this.size = size;
            list = new int[size];
        }

        public void DisplayData()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
        }

        public void FillWithRandomData(int start = 1, int end = 100)
        {
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                list[i] = random.Next(start, end);
            }
        }

        public void GetUserData()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"List[{i}]: ");
                string strInput = Console.ReadLine();
                list[i] = Convert.ToInt32(strInput);
            }
        }

        public void SelectionSort()
        {
            for (int iteration = 0; iteration < size - 1; iteration++)
            {
                int pos = LowestNumberIndex(list, iteration, size - 1);

                Swap(ref list[iteration], ref list[pos]);
            }
        }

        private static int LowestNumberIndex(int[] list, int start, int end)
        {
            int lowest = list[start];   // Take The First Number Of The Remaining List As Lowest
            int pos = start;            // Note Down It's Position

            for (int j = start + 1; j <= end; j++)
                if (list[j] < lowest)       // Found A New Lowest
                {
                    lowest = list[j];
                    pos = j;
                }

            return pos;
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void InsertionSort()
        {
            for (int index = 1; index < size; index++)
            {
                int j;

                // Take The Number Out At Index Location
                int number = list[index];

                // Shift The Numbers To The Right As Long As Previous Number list[j-1]
                // is greater than number and we are not at the begining (j>0)
                for (j = index; j > 0 && list[j - 1] > number; j--)
                    list[j] = list[j - 1];

                list[j] = number;
            }
        }

        public void ShellSort()
        {
            bool swapped = true;
            int gap = size / 2;

            // If The Gap Is 1 And No Swaps Happen, The List Is Sorted
            while (swapped)
            {
                swapped = false;

                // Perform Comparison At Gap Distance
                for (int index = 0; (index + gap) < size; index++)
                    if (list[index] > list[index + gap])
                    {
                        Swap(ref list[index], ref list[index + gap]);

                        swapped = true;
                    }

                if (!swapped && gap > 1)
                {
                    gap = gap / 2;
                    swapped = true;
                }
            }
        }

        public void QuickSort()
        {
            QuickSort(0, size - 1);
        }

        private void QuickSort(int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                // Find The Location Of Pivot
                int pivotIndex = FindPivot(startIndex, endIndex);

                // Sort The Left Of Pivot
                QuickSort(startIndex, pivotIndex - 1);

                // Sort The Right Of Pivot
                QuickSort(pivotIndex + 1, endIndex);
            }
        }

        private int FindPivot(int startIndex, int endIndex)
        {
            int pivot = list[startIndex];   // We Choose 1st Element As Pivot
            int low = startIndex + 1;       // We Start low from Start+1
            int high = endIndex;            // We start high from End

            while (low < high)
            {
                while (low < high && list[low] <= pivot)
                    low++;

                while (low <= high && list[high] > pivot)
                    high--;

                if (low < high)
                    Swap(ref list[low], ref list[high]);
            }

            Swap(ref list[startIndex], ref list[high]);

            return high;
        }
    }

    public interface IArrayList
    {
        void GetUserData();
        void FillWithRandomData(int start = 1, int end = 100);
        void DisplayData();
        void SelectionSort();
        void InsertionSort();
        void ShellSort();
        void QuickSort();
    }
}

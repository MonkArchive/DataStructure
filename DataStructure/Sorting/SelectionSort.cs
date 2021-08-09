using System;

namespace Sorting
{
    public class ArrayList : IArrayList
    {
        int[] list;
        int size;

        public ArrayList( int size )
        {
            this.size = size;
            list = new int[size];
        }

        public void DisplayData()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write( list[i] + " " );
            }

            Console.WriteLine();
        }

        public void FillWithRandomData( int start = 1, int end = 100 )
        {
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                list[i] = random.Next( start, end );
            }
        }

        public void GetUserData()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write( $"List[{i}]: " );
                string strInput = Console.ReadLine();
                list[i] = Convert.ToInt32( strInput );
            }
        }

        public void SelectionSort()
        {
            for (int iteration = 0; iteration < size - 1; iteration++)        
            {
                int pos = LowestNumberIndex(list, iteration, size-1 );

                Swap( ref list[iteration], ref list[pos] );
            }
        }

        private static int LowestNumberIndex( int[] list, int start, int end )
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

        private static void Swap( ref int x, ref int y )
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }

    public interface IArrayList
    {
        void GetUserData();
        void FillWithRandomData( int start = 1, int end = 100 );
        void DisplayData();
        void SelectionSort();
    }
}

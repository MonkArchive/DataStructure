using System;
using System.Drawing;

namespace LinearSearch
{
    public class LinearList : ILinearList
    {
        int[] list;
        int size;

        public LinearList( int size )
        {
            this.size = size;
            list = new int[size];
        }

        public bool Contains( int item )
        {
            for (int i = 0; i < size; i++)
                if (list[i] == item)
                    return true;

            return false;
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

        public int FindFirst( int item )
        {
            for (int i = 0; i < size; i++)
                if (list[i] == item)
                    return i;

            return -1;
        }

        public int FindOccurences( int item )
        {
            int count = 0;

            for (int i = 0; i < size; i++)
                if (list[i] == item)
                    ++count;

            return count;
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
    }

    public interface ILinearList
    {
        void GetUserData();
        void FillWithRandomData( int start = 1, int end = 100 );
        void DisplayData();
        int FindFirst( int item );          // Return Index Of That Item, -1 if absent
        int FindOccurences( int item );     // Return The Number Of Times Item Is Present In The List
        bool Contains( int item );          // Return True / False Depending Upon If The Item Exists
    }
}

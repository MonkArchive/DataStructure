using System;

namespace BinarySearch
{
    class BinaryList : IBinaryList
    {
        int[] list;
        int size;

        public BinaryList( int size )
        {
            this.size = size;
            list = new int[size];
        }

        public bool Contains( int item )
        {
            return Find( item ) != -1;
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

            Array.Sort( list );
        }

        public int Find( int item )
        {
            return BinarySearch( 0, size-1, item );
        }

        private int BinarySearch( int lower, int upper, int item )
        {
            int mid = (lower + upper) / 2;

            if (lower > upper)
                return -1;
            else
                if (list[mid] == item)
                    return mid;
                else
                    if (list[mid] > item)
                        return BinarySearch( lower, mid - 1, item );
                    else
                        return BinarySearch( mid + 1, upper, item );
        }

        //public int Find( int item )
        //{
        //    int lower = 0;
        //    int upper = size-1;
        //    int mid = -1;
        //    bool isFound = false;

        //    while (!isFound && (lower <= upper))
        //    {
        //        mid = (lower + upper) / 2;

        //        if (list[mid] == item)
        //            isFound = true;
        //        else
        //            if (list[mid] > item)
        //            upper = mid - 1;
        //        else
        //            lower = mid + 1;
        //    }

        //    return isFound ? mid : -1;

        //    //while ((list[mid] != item) && (lower <= upper))
        //    //{
        //    //    // It Means The Number Is Not Found And Upper >= Lower
        //    //    mid = (lower + upper) / 2;

        //    //    if (list[mid] > item)
        //    //        upper = mid - 1;
        //    //    else
        //    //        if (list[mid] < item)
        //    //        lower = mid + 1;
        //    //}

        //    //return lower <= upper ? mid : -1;
        //}

        public void GetUserData()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write( $"List[{i}]: " );
                string strInput = Console.ReadLine();
                list[i] = Convert.ToInt32( strInput );
            }

            Array.Sort( list );
        }
    }

    public interface IBinaryList
    {
        void GetUserData();
        void FillWithRandomData( int start = 1, int end = 100 );
        void DisplayData();
        int Find( int item );          // Return Index Of That Item, -1 if absent
        bool Contains( int item );          // Return True / False Depending Upon If The Item Exists
    }
}

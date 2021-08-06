using System;

namespace BinarySearch
{
    class Program
    {
        static void Main( string[] args )
        {
            int[] list;
            int size;

            // Get The Size Of The List
            Console.Write( "How Many Elements [N]: " );
            string strInput = Console.ReadLine();
            size = Convert.ToInt32( strInput );

            // Create The Array With Size 'size'
            list = new int[size];

            // Get The User Input For The List
            for (int i = 0; i < size; i++)
            {
                Console.Write( $"List[{i}]: " );
                strInput = Console.ReadLine();
                list[i] = Convert.ToInt32( strInput );
            }

            Array.Sort( list );

            Console.Write( "What Value To Search: " );
            strInput = Console.ReadLine();
            int ele = Convert.ToInt32( strInput );

            Console.Write( $"The {ele} Exists At Index {BinarySearch(list, 0, size-1, ele)}" );
        }

        private static int BinarySearch(int[] list,  int lower, int upper, int item )
        {
            int mid = (lower + upper) / 2;

            if (lower > upper)
                return -1;
            else
                if (list[mid] == item)
                return mid;
            else
                    if (list[mid] > item)
                return BinarySearch( list, lower, mid - 1, item );
            else
                return BinarySearch( list, mid + 1, upper, item );
        }
    }
}

using System;

namespace BinarySearch
{
    class Program
    {
        static void Main( string[] args )
        {
            IBinaryList list = new BinaryList(10);

            list.FillWithRandomData();
            list.DisplayData();

            Console.Write( "Enter The Number To Search: " );
            string strInput = Console.ReadLine();
            int number = Convert.ToInt32(strInput);

            Console.WriteLine( $"{number} Exists In The List At Index {list.Find( number )}" );
        }
    }
}

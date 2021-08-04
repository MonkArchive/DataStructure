using System;

namespace LinearSearch
{
    class Program
    {
        static void Main( string[] args )
        {
            ILinearList list = new LinearList(10);

            list.FillWithRandomData();
            list.DisplayData();

            Console.Write( "Enter The Number To Search: " );
            string strInput = Console.ReadLine();
            int number = Convert.ToInt32(strInput);

            Console.WriteLine( $"{number} Exists In The List At {list.FindFirst( number )} Index" );
            Console.WriteLine( $"{number} Exists In The List {list.FindOccurences( number )} Times" );
            Console.WriteLine( $"{number} Present In The List: {list.Contains( number )}" );
        }
    }
}

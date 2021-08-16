using System;

namespace OurList
{
    class Program
    {
        static void Main( string[] args )
        {
            IOurList list = new OurList(10);

            list.FillWithRandomData();
            list.DisplayData();

            list.BubbleSort();

            list.DisplayData();
        }
    }
}

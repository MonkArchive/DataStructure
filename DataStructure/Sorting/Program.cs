namespace Sorting
{
    class Program
    {
        static void Main( string[] args )
        {
            IArrayList list = new ArrayList (10);

            list.FillWithRandomData();
            list.DisplayData();

            list.QuickSort();

            list.DisplayData();
        }
    }
}

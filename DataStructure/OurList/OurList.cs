using System;

namespace OurList
{
    public class OurList : IOurList
    {
        int[] list;
        int size;

        public OurList( int size )
        {
            this.size = size;
            list = new int[size];
        }

        public int this[int index] 
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public void BubbleSort()
        {
            for (int iteration = 0; iteration < size-1; iteration++)
            {
                for (int pairs = 0; pairs < size - iteration - 1; pairs++)
                    if (list[pairs] > list[pairs+1])
                    {
                        int temp = list[pairs];
                        list[pairs] = list[pairs + 1];
                        list[pairs + 1] = temp;
                    }
            }
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
    }

    public interface IOurList
    {
        int this[int index]
        {
            get;
            set;
        }
        void GetUserData();
        void FillWithRandomData( int start = 1, int end = 100 );
        void DisplayData();
        void BubbleSort();
    }
}

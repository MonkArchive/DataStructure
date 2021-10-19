using System;

namespace ArmStrong
{
    class Program
    {
        static void Main( string[] args )
        {
            // Find All The 3 Digit Armstrong Numbers
            // Method 6
            // 
            // Iterations               : [900]
            // Divisiion Operation      : 0
            // Multiplications          : 0
            // Additions                : 2700
            // Assignments              : 0
            int[] cubes = {0, 1, 8, 27, 64, 125, 216, 343, 512, 729};

            int n = 100;
            for (int i = 1; i <= 9; i++)
                for (int j = 0; j <= 9; j++)
                    for (int k = 0; k <= 9; k++)
                    {
                        if (cubes[i] + cubes[j] + cubes[k] == n)
                            Console.WriteLine( $"{n} is an Armstrong Number" );
                        n++;
                    }

            //// Method 5
            //// 
            //// Iterations               : [900]
            //// Divisiion Operation      : 0
            //// Multiplications          : 5400
            //// Additions                : 2700
            //// Assignments              : 0
            //int n = 100;
            //for (int i = 1; i <= 9; i++)
            //    for (int j = 0; j <= 9; j++)
            //        for (int k = 0; k <= 9; k++)
            //        {
            //            if (i * i * i + j * j * j + k * k * k == n)
            //                Console.WriteLine( $"{n} is an Armstrong Number" );
            //            n++;
            //        }

            //// Method 4
            //// 
            //// Iterations               : [900]
            //// Divisiion Operation      : 0
            //// Multiplications          : 7200
            //// Additions                : 3600
            //// Assignments              : 900
            //for (int i = 1; i <= 9; i++)
            //    for (int j = 0; j <= 9; j++)
            //        for (int k = 0; k <= 9; k++)
            //        {
            //            int no = i * 100 + j * 10 + k;

            //            if (i * i * i + j * j * j + k * k * k == no)
            //                Console.WriteLine( $"{no} is an Armstrong Number" );
            //        }

            //// Method 3
            //// 
            //// Iterations               : [900]
            //// Divisiion Operation      : 0
            //// Multiplications          : 9000
            //// Additions                : 5400
            //// Assignments              : 0
            //for (int i = 1; i <= 9; i++)
            //    for (int j = 0; j <= 9; j++)
            //        for (int k = 0; k <= 9; k++)
            //        {
            //            if (i * i * i + j * j * j + k * k * k == i * 100 + j * 10 + k)
            //                Console.WriteLine( $"{i * 100 + j * 10 + k} is an Armstrong Number" );
            //        }

            //// Method 1
            //// 
            //// Iterations               : [900]
            //// Divisiion Operation      : 3600
            //// Multiplications          : 5400
            //// Additions                : 1800
            //// Assignments              : 2700
            //for (int i = 100; i <= 999; i++)
            //{
            //    int unit = i % 10;
            //    int tens = (i / 10) % 10;
            //    int hundred = i / 100;

            //    if (unit * unit * unit + tens * tens * tens + hundred * hundred * hundred == i)
            //        Console.WriteLine( $"{i} is an Armstrong Number" );
            //}

            //// Method 2
            //// 
            //// Iterations               : [2700]
            //// Divisiion Operation      : 5400
            //// Multiplications          : 5400 + function call overhead (2700)
            //// Additions                : 2700
            //// Assignments              : 1800 + 2700

            //for (int i = 100; i <= 999; i++)
            //{
            //    int sum = 0;
            //    int no = i ;

            //    while (no > 0)
            //    {
            //        int digit=no % 10;
            //        no /= 10;
            //        sum += (int) Math.Pow( digit, (double) 3 );
            //    }

            //    if (sum == i)
            //        Console.WriteLine( $"{i} is an Armstrong Number" );
            //}

        }
    }
}

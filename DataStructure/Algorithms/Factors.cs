using System;

namespace Algorithms
{
    public static class Factors
    {
        /// <summary>
        /// Display Prime Factors Of A Number N, e.g., N = 100, Print 2, 5
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static void GeneratePrimeFactors(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    if (IsPrime(i))
                        Console.WriteLine(i);
        }

        /// <summary>
        /// Generate Prime Numbers
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static void GeneratePrime_2(int n)
        {
            int[] list = new int[n+1];

            for (int i = 0; i <= n; i++)
                list[i] = i;

            for (int i = 2; i <= n; i++)
            {
                if (list[i] != 0)
                {
                    Console.Write($"{i}, ");

                    // Make All Multiples of 'i' '0'in the list
                    for (int j = i; j <= n; j += i)
                        list[j] = 0;
                }
            }
        }

        /// <summary>
        /// Generate Prime Numbers
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static void GeneratePrime_1(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;

                for (int j = 2; (j <= Math.Sqrt(i)) && isPrime; j++)
                    isPrime = (i % j != 0);

                if (isPrime)
                    Console.Write($"{i}, ");
            }
        }

        /// <summary>
        /// Check If A Given Number Is Primt Or Not, N >= 1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime(int n)
        {
            bool isPrime = true;

            for (int i = 2; (i <= Math.Sqrt(n)) && isPrime; i++)
                isPrime = (n % i != 0);

            return isPrime;
        }

        /// <summary>
        /// Find The Sum Of Factors Of A Number N, N == 100, S = 2 + 4 + 5 + 10 + 20 + 25 + 50
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfFactors(int n)
        {
            int sum = 0;

            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    sum = sum + i;

            return 0;
        }

        public static double SQRT(int n)
        {
            double low = 0;
            double high = n;

            while (Math.Abs(high - low) > 0.001)
            {
                high = (low + high) / 2;
                low = n / high;
            }

            return high;
        }

        public static int LCM_2(int m, int n)
        {
            return (m * n) / GCD_5(m, n);
        }

        public static int LCM_1(int m, int n)
        {
            int divisor = 2;
            int LCM = 1;

            while ((divisor <= m / 2) && (divisor <= n / 2))
            {
                while ((m % divisor == 0) && (n % divisor == 0))
                {
                    m = m / divisor;
                    n = n / divisor;
                    LCM = LCM * divisor;
                }

                divisor++;
            }

            return LCM * m * n;
        }

        public static int GCD_5(int m, int n)
        {
            int r;

            if ((r = m % n) == 0)
                return n;
            else
                return GCD_5(n, r);
        }

        public static int GCD_4(int m, int n)
        {
            int r;

            while ((r = m % n) != 0)
            {
                m = n;
                n = r;
            }

            return n;
        }

        public static int GCD_3(int m, int n)
        {
            int r;

            if (m < n)
            {
                int t = m;
                m = n;
                n = t;
            }

            while ((r = m % n) != 0)
            {
                m = n;
                n = r;
            }

            return n;
        }

        public static int GCD_2(int m, int n)
        {
            if (m < n)
            {
                int t = m;
                m = n;
                n = t;
            }

            while (m % n != 0)
            {
                int r = m % n;
                m = n;
                n = r;
            }

            return n;
        }

        public static int GCD_1(int m, int n)
        {
            int divisor = 1;
            int gcd = 1;

            while ((divisor <= m) && (divisor <= n))
            {
                if ((m % divisor == 0) && (n % divisor == 0))
                    gcd = divisor;
            }

            return gcd;
        }
    }
}

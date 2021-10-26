using System;

namespace Algorithms
{
    public static class AnotherSeries
    {
        /// <summary>
        /// Sum Of series, e.g., S = X^2 / 1! - X^4 / 3! + X^6 / 5! + ...N Terms
        /// </summary>
        /// <returns></returns>
        public static double Series_10(int n, int x)
        {
            // Initialize Variables
            double sum = 0;
            int fact = 1;
            int power = 1;
            int sign = 1;

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                power = power * x * x;

                sum = sum + power / fact;

                fact = fact * (2 * loop) * (2 * loop + 1);
                sign = sign * -1;

                // Increment Loop
                loop++;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of series, e.g., S = 1! + 3! + 5! + ...N Terms
        /// </summary>
        /// <returns></returns>
        public static int Series_9(int n)
        {
            // Initialize Variables
            int sum = 0;
            int fact = 1;

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum = sum + fact;

                fact = fact * (2 * loop) * (2 * loop + 1);

                // Increment Loop
                loop++;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of series, e.g., S = X/1! + X^2/2! + X^3/3! + ...X^N/N! 
        /// </summary>
        /// <returns></returns>
        public static int Series_8(int n, int x)
        {
            // Initialize Variables
            int sum = 0;
            int fact = 1;
            int power = x;

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum = sum + power / fact;

                // Increment Loop
                loop++;

                power = power * x;
                fact = fact * loop;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of series, e.g., S = 1/1! + 2/2! + 3/3! + ...N/N! 
        /// </summary>
        /// <returns></returns>
        public static int Series_7(int n)
        {
            // Initialize Variables
            int sum = 0;
            int fact = 1;   

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum = sum + loop / fact;

                // Increment Loop
                loop++;

                fact = fact * loop;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of series, e.g., S = X^1 - X^2 + X^3 - X^4...X^N 
        /// </summary>
        /// <returns></returns>
        public static int Series_7(int n, int x)
        {
            // Initialize Variables
            int sum = 0;
            int term = x;   // 1st Term

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum = sum + term;

                // Get The Next Term
                term = term * -x;

                // Increment Loop
                loop++;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of series, e.g., S = 1 + 1/2 + 1/3 +...1/N 
        /// </summary>
        /// <returns></returns>
        public static double Series_6(int n)
        {
            // Initialize Variables
            double sum = 0;

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum = sum + 1 / loop;

                // Increment Loop
                loop++;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of series, e.g., S = F(1) + F(2) + F(3) +...+ F(N), N >= 2
        /// </summary>
        /// <returns></returns>
        public static int Series_5(int n)
        {
            // Initialize Variables
            int sum = 0;
            int f1 = 1;   // 1st Term, F(1)
            int f2 = 1;

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum = sum + f1;

                // Get The Next Term
                int f3 = f1 + f2;

                f1 = f2;
                f2 = f3;

                // Increment Loop
                loop++;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of series, e.g., S = 1! + 2! + 3! +...+ N!
        /// </summary>
        /// <returns></returns>
        public static int Series_4_2(int n)
        {
            // Initialize Variables
            int sum = 0;

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum = sum + fact(loop);

                // Increment Loop
                loop++;
            }

            return sum;
        }

        private static int fact(int loop)
        {
            int fact = 1;

            for (int i = 1; i <= loop; i++)
            {
                fact = fact * i;
            }

            return fact;
        }

        /// <summary>
        /// Sum Of series, e.g., S = 1! + 2! + 3! +...+ N!
        /// </summary>
        /// <returns></returns>
        public static int Series_4(int n)
        {
            // Initialize Variables
            int sum = 0;
            int term = 1;   // 1st Term, 1!

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum = sum + term;

                // Get The Next Term
                term = term * (loop + 1);            // 2! = 1! * 2

                // Increment Loop
                loop++;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of series, e.g., S = X^2 + X^4 + X^6 +...X^N
        /// </summary>
        /// <returns></returns>
        public static int Series_3(int n, int x)
        {
            // Initialize Variables
            int sum = 0;
            int term = 1;   

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Get The Next Term
                term = term * x * x;

                // Add The Term To Sum
                sum = sum + term;

                // Increment Loop
                loop += 2;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of series, e.g., S = X^1 + X^3 + X^ +...X^N
        /// </summary>
        /// <returns></returns>
        public static int Series_2(int n, int x)
        {
            // Initialize Variables
            int sum = 0;
            int term = x;   // 1st Term

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum = sum + term;

                // Get The Next Term
                term = term * x * x;

                // Increment Loop
                loop += 2;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of series, e.g., S = X^1 + X^2 + X^3 +...X^N 
        /// </summary>
        /// <returns></returns>
        public static int Series_1(int n, int x)
        {
            // Initialize Variables
            int sum = 0;
            int term = x;   // 1st Term

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum = sum + term;

                // Get The Next Term
                term = term * x;

                // Increment Loop
                loop++;
            }

            return sum;
        }
    }
}

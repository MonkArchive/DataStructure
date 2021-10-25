using System.Linq.Expressions;

namespace Algorithms
{
    public static class Series
    {
        /// <summary>
        /// Sum Of Alternating Sign Of N Odd Numbers, e.g., S = 1 - 3 + 5 - 7 +...N Terms
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Sum_Of_Alternating_Sign_Odds(int n)
        {
            // Initialize Variables
            int sum = 0;
            int term = 1;   // 1st Term
            int sign = 1;   // Sign = +1

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum = sum + sign * term;

                // Change The Sign
                sign = sign * (-1);

                // Get The Next Term
                term += 2;

                // Increment Loop
                loop++;
            }

            return sum;
        }


        /// <summary>
        /// Sum Of Alternating Sign Of N Natural Numbers, e.g., S = 1 - 2 + 3 - 4 +...+ N; S = (N * N+1))/2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //public static int Sum_Of_Alternating_Sign_Natural(int n)
        //{
        //    // Initialize Variables
        //    int sumOdd = 0;
        //    int term = 1;   // 1st Term

        //    // Now, Loop Thru N Terms
        //    int loop = 1;

        //    while (loop <= n)
        //    {
        //        // Add The Term To Sum
        //        sumOdd += term;

        //        // Get The Next Term
        //        term += 2;

        //        // Increment Loop
        //        loop++;
        //    }

        //    // Initialize Variables
        //    int sumEven = 0;
        //    int term = 2;   // 1st Term

        //    // Now, Loop Thru N Terms
        //    int loop = 1;

        //    while (loop <= n)
        //    {
        //        // Add The Term To Sum
        //        sumEven += term;

        //        // Get The Next Term
        //        term += 2;

        //        // Increment Loop
        //        loop++;
        //    }

        //    return sumOdd - sumEven;
        //}
        //public static int Sum_Of_Alternating_Sign_Natural(int n)
        //{
        //    // Initialize Variables
        //    int sum = 0;
        //    int term = 1;   // 1st Term

        //    // Now, Loop Thru N Terms
        //    int loop = 1;

        //    while (loop <= n)
        //    {
        //        // Add The Term To Sum
        //        sum = sum + (term % 2 != 0 ? term : -term);

        //        // Get The Next Term
        //        term++;

        //        // Increment Loop
        //        loop++;
        //    }

        //    return sum;
        //}
        public static int Sum_Of_Alternating_Sign_Natural(int n)
        {
            // Initialize Variables
            int sum = 0;
            int term = 1;   // 1st Term
            int sign = 1;   // Sign = +1

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum = sum + sign * term;

                // Change The Sign
                sign = sign * (-1);

                // Get The Next Term
                term++;

                // Increment Loop
                loop++;
            }

            return sum;
        }


        /// <summary>
        /// Sum Of First N Natural Numbers, e.g., S = 1 + 2 + 3 + 4 +...+ N; S = (N * N+1))/2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfNatural(int n)
        {
            // Initialize Variables
            int sum = 0;
            int term = 1;   // 1st Term

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum += term;

                // Get The Next Term
                term++;

                // Increment Loop
                loop++;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of First N Odd Numbers, e.g., S = 1 + 3 + 5 + 7 +...N Terms; 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Sum_Of_N_Odd_Numbers(int n)
        {
            // Initialize Variables
            int sum = 0;
            int term = 1;   // 1st Term

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum += term;

                // Get The Next Term
                term = term + 2;

                // Increment Loop
                loop++;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of First N Even Numbers, e.g., S = 2 + 4 + 6 + 8 +...N Terms; 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Sum_Of_N_Even_Numbers(int n)
        {
            // Initialize Variables
            int sum = 0;
            int term = 2;   // 1st Term

            // Now, Loop Thru N Terms
            int loop = 1;

            while (loop <= n)
            {
                // Add The Term To Sum
                sum += term;

                // Get The Next Term
                term = term + 2;

                // Increment Loop
                loop++;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of Odd Numbers Upto N, e.g., S = 1 + 3 + 5 + 7 +...+ N 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Sum_Of_Odd_Numbers_Upto_N(int n)
        {
            // Initialize Variables
            int sum = 0;
            int term = 1;   // 1st Term

            while (term <= n)
            {
                // Add The Term To Sum
                sum += term;

                // Get The Next Term
                term += 2;
            }

            return sum;
        }

        /// <summary>
        /// Sum Of Even Numbers Upto N, e.g., S = 2 + 4 + 6 +...+ N 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Sum_Of_Even_Numbers_Upto_N(int n)
        {
            // Initialize Variables
            int sum = 0;
            int term = 2;   // 1st Term

            while (term <= n)
            {
                // Add The Term To Sum
                sum += term;

                // Get The Next Term
                term += 2;
            }

            return sum;
        }

        ///// <summary>
        ///// Sum Of Numbers, Divisible By X, Upto N, e.g., S = X + X^2 + .. + N 
        ///// </summary>
        ///// <param name="n"></param>
        ///// <returns></returns>
        //public static int Sum_Of_Divisble_Numbers_Upto_N(int n, int x)
        //{
        //    // Initialize Variables
        //    int sum = 0;

        //    // Now, Loop Thru N Terms
        //    int loop = 1;

        //    while (loop <= n)
        //    {
        //        // Add The Term To Sum If It Fulfills Condition
        //        if (loop % x == 0)
        //            sum += loop;

        //        // Increment Loop
        //        loop++;
        //    }

        //    return sum;
        //}

        /// <summary>
        /// Sum Of Numbers, Divisible By X, Upto N, e.g., S = X + X^2 + .. + N 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Sum_Of_Divisble_Numbers_Upto_N(int n, int x)
        {
            // Initialize Variables
            int sum = 0;
            int term = x;   // 1st Term

            while (term <= n)
            {
                // Add The Term To Sum
                sum += term;

                // Get The Next Term
                term += x;
            }

            return sum;
        }

    }
}

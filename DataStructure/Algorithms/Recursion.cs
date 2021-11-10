using System;

namespace Algorithms
{
    public static class Recursion
    {
        public static string DecToBin(int n)
        {
            if (n > 1)
                return DecToBin(n / 2) + n % 2;
            else
                return n + string.Empty;
        }

        public static string DecToBase(int n, int b = 2)
        {
            if (n > 1)
                return DecToBase(n / b, b) 
                    + (n % b > 10 ? Convert.ToChar((n%b)-10+'A').ToString() : n % b );
            else
                return n + string.Empty;
        }
    }
}

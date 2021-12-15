namespace Dynamic;

public class Alogorithms
{
    static int[] Fibo = new int[100]; 

    /// <summary>
    /// Return The Nth Fibonnaci Number
    /// </summary>
    /// <param name="n">Max Limit: 100</param>
    /// <returns>Nth Fibo</returns>
    public static int NthFibonacci(int n)
    {
        int f;

        if (Fibo[n] != 0)
            return Fibo[n];

        if ((n == 1) || (n == 2))
            f = 1;
        else
            f = NthFibonacci(n - 1) + NthFibonacci(n - 2);

        Fibo[n] = f;

        return f;
    }
}

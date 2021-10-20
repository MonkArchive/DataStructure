using System;

namespace PolishNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string expr = GetAnInput();

            int result = EvalPolish.EvaluatePrefix(expr);

            Console.WriteLine($"{expr} is equal to {result}");
        }

        private static string GetAnInput()
        {
            Console.Write("Enter A Postfix Expr: ");
            return Console.ReadLine();
        }
    }
}

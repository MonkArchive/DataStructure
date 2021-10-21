using System;

namespace PolishNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string expr = "((1+2)*(3+4))";

            var result = ConvertPolish.InfixToPreFix(expr);

            Console.WriteLine($"{expr} in Popstfix is {result}");
        }

        private static string GetAnInput()
        {
            Console.Write("Enter A Postfix Expr: ");
            return Console.ReadLine();
        }
    }
}

using System;

namespace ExpressionTree
{
    /// <summary>
    /// Constraints:
    ///     1. Only +, -, *, / are allowed
    ///     2. Only single digit operands are allowed
    ///     3. Minimum Errpr Checking has been done
    ///     4. Only Binary Operators are used
    ///     5. Expression Is Fully Parenthesised
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var expr = "((1+2)*3)";
            var exprTree = new ExpressionTree(expr);

            Console.WriteLine($"{expr} evaluates to {exprTree.Evaluate()}");
        }
    }
}

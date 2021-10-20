using System;
using System.Linq;

/// <summary>
/// Constraints:
///     1. Only +, -, *, / are allowed
///     2. Only single digit operands are allowed
///     3. Minimum Errpr Checking has been done
///     4. Only Binary Operators are used
/// </summary>

namespace PolishNotation
{
    class ConvertPolish
    {
        public static string InfixToPostFix(string expr)
        {
            string result = string.Empty;

            return result;
        }
    }

    class EvalPolish
    {
        public static int EvalPostfix(string expr)
        {
            IStack<int> stack = new Stack<int>(100);

            foreach (char ch in expr)
            {
                if (Char.IsDigit(ch))
                    stack.Push(((byte)ch) - '0');

                else if (IsOperator(ch))
                {
                    var op1 = stack.Pop();
                    var op2 = stack.Pop();

                    stack.Push(Caculate(ch, op1, op2));
                }
            }

            return stack.Pop();
        }

        public static int EvalPrefix(string expr)
        {
            expr = ReverseString(expr);

            return EvalPostfix(expr);
        }

        static int i = 0;

        public static int EvaluatePrefix(string expr)
        {
            var ch = expr[i++];

            if (IsOperator(ch))
            {
                int op1 = EvaluatePrefix(expr);
                int op2 = EvaluatePrefix(expr);

                return Caculate(ch, op2, op1);
            }
            else if (Char.IsDigit(ch))
                return (byte)ch - '0';
            else
                throw new Exception("Invalid Character");
        }

        private static string ReverseString(string expr)
        {
            string str = string.Empty;

            foreach (char ch in expr)
                str = ch + str;

            return str;
        }

        private static int Caculate(char ch, int op1, int op2)
        {
            return ch switch
            {
                '+' => op2 + op1,
                '-' => op2 - op1,
                '*' => op2 * op1,
                '/' => op2 / op1,
                _ => throw new Exception("Invalid Opeartor"),
            };
        }

        private static bool IsOperator(char ch)
        {
            return (ch == '+' || ch == '-' || ch == '*' || ch == '/');
        }
    }


}

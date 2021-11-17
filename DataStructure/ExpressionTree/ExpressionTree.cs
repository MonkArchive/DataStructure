using System;

namespace ExpressionTree
{
    public class ExpressionTree
    {
        private TreeNode _root { get; set; }
        static int i = 0;

        public ExpressionTree()
        {
            _root = null;
        }

        public ExpressionTree(string expr)
        {
            i = 0;
            _root = CreateExpressionTree(expr);
        }

        private TreeNode CreateExpressionTree(string expr)
        {
            var ch = expr[i++];

            while (ch == ')')
                ch = expr[i++];

            // If It Is A '('; We Have A SubExpression; (1+2); ((1+2)*(3+4))
            if (ch == '(')
            {
                var leftTree = CreateExpressionTree(expr);

                var newRoot = CreateExpressionTree(expr);

                var rightTree = CreateExpressionTree(expr);

                newRoot.Left = leftTree;
                newRoot.Right = rightTree;

                return newRoot;
            } 
            else if (IsOperator(ch) || Char.IsDigit(ch))
            {
                return new TreeNode(ch);
            } 
            else
                throw new Exception("Invalid Expression");
        }

        public int Evaluate()
        {
            return EvaluateExpressionTree(_root);
        }

        private int EvaluateExpressionTree(TreeNode root)
        {
            if (IsOperator(root.Data))
            {
                return Calculate(root.Data,
                                 EvaluateExpressionTree(root.Left),
                                 EvaluateExpressionTree(root.Right));
            } 
            else
                return ((int)root.Data) - '0';
        }

        private static bool IsOperator(char ch)
        {
            return (ch == '+' || ch == '-' || ch == '*' || ch == '/');
        }

        private static int Calculate(char ch, int op1, int op2)
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

    }
}

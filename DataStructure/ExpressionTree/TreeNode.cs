namespace ExpressionTree
{
    public class TreeNode
    {
        public char Data { get; set; }

        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode()
        {
            Data = default;
            Left = Right = null;
        }

        public TreeNode(char data)
        {
            Data = data;
            Left = Right = null;
        }
    }
}

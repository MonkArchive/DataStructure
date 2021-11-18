namespace AVL_Trees
{
    public class TreeNode
    {
        public int Data { get; set; }

        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode()
        {
            Data = default;
            Left = Right = null;
        }

        public TreeNode(int data)
        {
            Data = data;
            Left = Right = null;
        }
    }
}

using System;

namespace AVL_Trees
{
    public class HeightBalancedTree
    {
        private TreeNode _root { get; set; }

        public HeightBalancedTree()
        {
            _root = null;
        }

        public void Insert(TreeNode node)
        {
            _root = InsertNode(_root, node);
        }

        public int Height()
        {
            return Height(_root);
        }

        public void Delete(TreeNode node)
        {
            _root = DeleteNode(_root, node);
        }

        public TreeNode Search(int data)
        {
            return SearchTree(_root, data);
        }

        private TreeNode InsertNode(TreeNode root, TreeNode node)
        {
            // Insert The Node At The Leaf Level
            if (root is null)
                root = node;
            else if (root.Data > node.Data)
                root.Left = InsertNode(root.Left, node);
            else if (root.Data < node.Data)
                root.Right = InsertNode(root.Right, node);
            else
                throw new Exception("Duplicate Data Values Are Not Allowed");

            // Find The Balance Of This 'root'
            int balance = Height(root.Left) - Height(root.Right);

            if (balance > 1 && node.Data < root.Left.Data) // Left Left Case
            {
                // Perform Right Rotation
                root =  RightRotate(root);
            }

            if (balance > 1 && node.Data > root.Left.Data) // Left Right Case
            {
                // Perform Left Rotation For Root.Left, And Right Rotation For Root
                root.Left = LeftRotate(root.Left);
                root =  RightRotate(root);
            }

            if (balance < -1 && node.Data > root.Right.Data) // Right Right Case
            {
                // Perform Left Rotation
                root = LeftRotate(root);
            }

            if (balance < -1 && node.Data < root.Right.Data) // Right Left Case
            {
                // Perform Right Rotation For Root.Right, And Left Rotation For Root
                root.Right = RightRotate(root.Right);
                root = LeftRotate(root);
            }

            return root;
        }

        private TreeNode LeftRotate(TreeNode root)
        {
            // Root.Right Is Going To Be The New Root
            var newRoot = root.Right;

            // Original Root.Right Will Now Hold root.Right.Left SubTree
            root.Right = newRoot.Left;

            // Move Original Root to The Left Of New Root
            newRoot.Left= root;

            return newRoot;
        }

        private TreeNode RightRotate(TreeNode root)
        {
            // Root.Left Is Going To Be The New Root
            var newRoot = root.Left;

            // Original Root.Left Will Now Hold root.Left.Right SubTree
            root.Left = newRoot.Right;

            // Move Original Root to The Right Of New Root
            newRoot.Right = root;

            return newRoot;
        }

        private TreeNode DeleteNode(TreeNode root, TreeNode node)
        {
            if (root.Data > node.Data)
                root.Left = DeleteNode(root.Left, node);
            else if (root.Data < node.Data)
                root.Right = DeleteNode(root.Right, node);
            else
            {
                if (root.Left is null && root.Right is null)
                    root = null;
                else if (root.Left is null)
                    root = root.Right;
                else if (node.Right is null)
                    root = root.Left;
                else
                {
                    TreeNode candidate = MaxDataNodeInLeftSubTree(root);
                    root.Data = candidate.Data;
                    root.Left = DeleteNode(root.Left, candidate);
                }
            }

            if (root is null)
                return root;

            // Find The Balance Of This 'root'
            int balance = GetBalance(root);

            if (balance > 1 && GetBalance(root.Left) >= 0) // Left Left Case
            {
                // Perform Right Rotation
                root = RightRotate(root);
            }

            if (balance > 1 && GetBalance(root.Left) < 0) // Left Right Case
            {
                // Perform Left Rotation For Root.Left, And Right Rotation For Root
                root.Left = LeftRotate(root.Left);
                root = RightRotate(root);
            }

            if (balance < -1 && GetBalance(root.Right) <= 0) // Right Right Case
            {
                // Perform Left Rotation
                root = LeftRotate(root);
            }

            if (balance < -1 && GetBalance(root.Right) > 0) // Right Left Case
            {
                // Perform Right Rotation For Root.Right, And Left Rotation For Root
                root.Right = RightRotate(root.Right);
                root = LeftRotate(root);
            }

            return root;

            static int GetBalance(TreeNode root) => Height(root.Left) - Height(root.Right);
        }

        private TreeNode MaxDataNodeInLeftSubTree(TreeNode root)
        {
            // Go to node.Left 
            var node = root.Left;

            // and keep on going node.Right as long as we can
            while (node.Right is not null)
                node = node.Right;

            return node;
        }

        private static TreeNode SearchTree(TreeNode root, int data)
        {
            if (root is null || root.Data == data)
                return root;
            else if (root.Data > data)
                return SearchTree(root.Left, data);
            else
                return SearchTree(root.Right, data);
        }

        private static int Height(TreeNode root)
        {
            if (root is null)
                return 0;
            else
                return Math.Max(Height(root.Left), Height(root.Right)) + 1;
        }
    }
}

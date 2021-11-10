using System;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        private TreeNode _root { get; set; }

        public BinaryTree()
        {
            _root = null;
        }

        public void Insert(TreeNode node)
        {
            _root = InsertNode(_root, node);
        }

        public void PreOrder(Action<TreeNode> ProcessNode)
        {
            PreOrderTraversal(_root, ProcessNode);

        }

        public void PostOrder(Action<TreeNode> ProcessNode)
        {
            PostOrderTraversal(_root, ProcessNode);
        }

        public void InOrder(Action<TreeNode> ProcessNode)
        {
            InOrderTraversal(_root, ProcessNode);
        }

        private static TreeNode InsertNode(TreeNode root, TreeNode node)
        {
            if (root is null)
                root = node;

            else if (root.Data > node.Data)
                root.Left = InsertNode(root.Left, node);

            else
                root.Right = InsertNode(root.Right, node);

            return root;
        }


        private void PostOrderTraversal(TreeNode root, Action<TreeNode> ProcessNode)
        {
            if (root is not null)
            {
                PostOrderTraversal(root.Left, ProcessNode);
                PostOrderTraversal(root.Right, ProcessNode);
                ProcessNode(root);
            }
        }

        private void InOrderTraversal(TreeNode root, Action<TreeNode> ProcessNode)
        {
            if (root is not null)
            {
                InOrderTraversal(root.Left, ProcessNode);
                ProcessNode(root);
                InOrderTraversal(root.Right, ProcessNode);
            }
        }

        private void PreOrderTraversal(TreeNode root, Action<TreeNode> ProcessNode)
        {
            if (root is not null)
            {
                ProcessNode(root);
                PreOrderTraversal(root.Left, ProcessNode);
                PreOrderTraversal(root.Right, ProcessNode);
            }
        }
    }
}

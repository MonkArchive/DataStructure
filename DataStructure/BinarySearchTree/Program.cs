using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(new TreeNode(10));
            binaryTree.Insert(new TreeNode(5));
            binaryTree.Insert(new TreeNode(20));
            binaryTree.Insert(new TreeNode(3));

            binaryTree.PreOrder(PrintNodeData);
            binaryTree.InOrder(PrintNodeData);
            binaryTree.PostOrder(PrintNodeData);

        }

        public static void PrintNodeData(TreeNode node)
        {
            Console.Write($"{node.Data}, ");
        }
    }
}

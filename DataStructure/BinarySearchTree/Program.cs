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

            binaryTree.LevelByLevelTraversal(PrintNodeData);

            Console.WriteLine();

            Console.WriteLine($"3 Exists in the database: {binaryTree.Search(3) is not null}");
            Console.WriteLine($"13 Exists in the database: {binaryTree.Search(13) is not null}");

            Console.WriteLine($"This Tree Has {binaryTree.CountLeaves()} Leaves");
            Console.WriteLine($"This Tree Has {binaryTree.CountNodes()} Nodes");
            Console.WriteLine($"This Tree Has Height of {binaryTree.Height()}");
        }

        public static void PrintNodeData(TreeNode node)
        {
            Console.Write($"{node.Data}, ");
        }
    }
}

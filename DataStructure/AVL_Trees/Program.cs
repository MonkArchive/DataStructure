using System;

namespace AVL_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            HeightBalancedTree binaryTree = new HeightBalancedTree();

            binaryTree.Insert(new TreeNode(3));
            binaryTree.Insert(new TreeNode(5));
            binaryTree.Insert(new TreeNode(8));
            binaryTree.Insert(new TreeNode(10));

            binaryTree.Delete(binaryTree.Search(3));

            //binaryTree.Insert(new TreeNode(20));
            //binaryTree.Insert(new TreeNode(15));
            //binaryTree.Insert(new TreeNode(25));
        }
    }
}

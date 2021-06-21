using System;


//https://www.algoexpert.io/questions/Height%20Balanced%20Binary%20Tree
namespace Check_for_Balanced_Binary_Tree
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree left = null;
        public BinaryTree right = null;

        public BinaryTree(int value)
        {
            this.value = value;
        }

        public static int isBalanced(BinaryTree root)
        {
            if (root == null)
                return 0;
            int lh = isBalanced(root.left);
            if (lh == -1) return -1;
            int rh = isBalanced(root.right);
            if (rh == -1) return -1;

            if (Math.Abs(lh - rh) > 1)
                return -1;
            else
                return Math.Max(lh, rh) + 1;
        }

        public bool HeightBalancedBinaryTree(BinaryTree tree)
        {
            int k = isBalanced(tree);
            return k == -1 ? false : true;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
    }
}


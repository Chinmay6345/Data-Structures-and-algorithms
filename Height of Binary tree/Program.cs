using System;
using Ttree_Traversals;

namespace Height_of_Binary_tree
{

    public static class AppHelper
    {
        public static Int32 Height(BinaryTree root)
        {
            if (root == null) return 0;
            else
                return Math.Max(Height(root.left), Height(root.right)) + 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}

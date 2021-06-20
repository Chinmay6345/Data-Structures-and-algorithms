using System;
using Ttree_Traversals;
namespace Print_nodes_at_distance_K
{

    public static class AppHelper
    {
        public static void NodesAtKDistance(BinaryTree root,Int32 k)
        {
            if (root == null) return;
            if (root.key == 0)
            {
                Console.Write(root.key + " ");
            }
            else
            {
                NodesAtKDistance(root.left, k - 1);
                NodesAtKDistance(root.right, k - 1);
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using Ttree_Traversals;

namespace Level_order_Traversal
{
    public static class AppHelper
    {
        public static void LevelOrder(BinaryTree root)
        {
            if (root == null)
            {
                return;
            }
            Queue<BinaryTree> q = new Queue<BinaryTree>();
            q.Enqueue(root);
            while (q.Any())
            {
                BinaryTree curr = q.Dequeue();
                Console.WriteLine(curr.key+" ");
                if (curr.left != null)
                {
                    q.Enqueue(curr.left);
                }
                if (curr.right != null)
                {
                    q.Enqueue(curr.right);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

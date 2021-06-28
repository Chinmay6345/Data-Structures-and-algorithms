using System;
using System.Linq;
using System.Collections.Generic;
using Count_nodes_in_a_complete_Binary_Tree;
namespace Iterative_In_order_traversal
{
    public static class AppHelper
    {
        public static void IterativeInorder(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while(stack.Any())
            {
                TreeNode curr = stack.Peek();
                Console.Write(curr.val + " ");
                stack.Pop();
                if(curr.left!=null)
                {
                   stack.Push(curr.left);
                }
                if(curr.right!=null)
                {
                    stack.Push(curr.right);
                }
            }
        }

        public static void IterativeInorder_SpaceOptimal(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            if (root == null)
                return;
            TreeNode curr = root;
            while(curr!=null)
            {
                while(curr!=null || stack.Count !=0)
                {
                    Console.Write(curr.val + " ");
                    if(curr.right!=null)
                    {
                        stack.Push(curr.right);
                    }
                    curr = curr.left;
                    if(stack.Count!=0)
                    {
                        curr = stack.Pop();
                    }
                }
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

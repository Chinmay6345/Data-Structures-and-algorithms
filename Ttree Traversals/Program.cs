using System;


namespace Ttree_Traversals
{

    public class BinaryTree
    {
        BinaryTree left;
        BinaryTree right;
        Int32 key;

        public BinaryTree(Int32 value)
        {
            key = value;
        }

        public void InOrder(BinaryTree root)
        {
            if(root!=null)
            {
                InOrder(root.left);
                Console.Write(root.key + " ");
                InOrder(root.right);
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

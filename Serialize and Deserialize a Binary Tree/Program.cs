using System;
using Ttree_Traversals;
using System.Collections.Generic;

namespace Serialize_and_Deserialize_a_Binary_Tree
{
    public static class AppHelper
    {
        public static void Serialize(BinaryTree root,List<Int32>lst)
        {
            if(root.Equals(null))
            {
                lst.Add(-1);
                return;
            }
            lst.Add(root.key);
            Serialize(root.left, lst);
            Serialize(root.right, lst);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

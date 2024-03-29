﻿using System;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            else if (p == null && q != null) return false;
            else if (p != null && q == null) return false;
            else if (p.val != q.val) return false;
            else return (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
  }
}

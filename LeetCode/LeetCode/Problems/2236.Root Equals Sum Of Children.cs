using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class RootEqualsSumOfChildren : Basic
    {
        public override void ShowResult()
        {
            Solution Problem = new Solution();
            int Root, Left, Right;
            Root = 10;
            Left = 4;
            Right = 6;
            TreeNode Node = new TreeNode(Root, new TreeNode(Left), new TreeNode(Right));
            bool Result = Problem.CheckTree(Node);
            System.Windows.Forms.MessageBox.Show(Result.ToString(), "Add Two Integers Result 1");
            Node = new TreeNode(Root, new TreeNode(Left), new TreeNode(Right));
            Result = Problem.CheckTree(Node);
            System.Windows.Forms.MessageBox.Show(Result.ToString(), "Add Two Integers Result 2");
        }

        //Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {
            public bool CheckTree(TreeNode root)
            {
                if (root.val == (root.left.val + root.right.val))
                {
                    return true;
                }
                else { return false; }
            }
        }
    }
}

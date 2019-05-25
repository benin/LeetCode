using System;
using Structures;

namespace MaximumDepthOfBinaryTree
{
    public class Solution
    {
        private int TraverseDown(TreeNode node, int depth)
        {
            int depthLeft = node.left != null ? TraverseDown(node.left, depth + 1) : depth;
            int depthRight = node.right != null ? TraverseDown(node.right, depth + 1) : depth;
            return depthLeft > depthRight ?  depthLeft : depthRight;
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            return TraverseDown(root, 1);
        }
    }
}

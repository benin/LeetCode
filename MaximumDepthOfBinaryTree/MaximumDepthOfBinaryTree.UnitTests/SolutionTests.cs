using NUnit.Framework;
using Structures;

namespace MaximumDepthOfBinaryTree.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SolutionLeetCodeTest()
        {
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);

            var node = root.right;
            node.left = new TreeNode(15);
            node.right = new TreeNode(7);

            var treeDepth = new Solution().MaxDepth(root);

            Assert.AreEqual(3, treeDepth);
        }

        [Test]
        public void SolutionEmptyTest()
        {
            TreeNode root = null;
            
            var treeDepth = new Solution().MaxDepth(root);

            Assert.AreEqual(0, treeDepth);
        }
    }
}
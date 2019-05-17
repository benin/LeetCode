using NUnit.Framework;
using System.Collections;

namespace ReverseLinkedList.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(SolutionTestCases), "TestCases")]
        public int[] SolutionTest(ListNode head)
        {
            return new Solution().ReverseList(head).ToArray();
        }
        
        [Test, TestCaseSource(typeof(SolutionTestCases), "TestCases")]
        public int[] SolutionTestRecursive(ListNode head)
        {
            return new Solution().ReverseListRecursive(head).ToArray();
        }
    }

    public static class SolutionTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(null).Returns(new int[]{}).SetName("Empty");
                yield return new TestCaseData(new ListNode(new int[]{1})).Returns(new int[]{1});
                yield return new TestCaseData(new ListNode(new int[]{1,2})).Returns(new int[]{2,1});
                yield return new TestCaseData(new ListNode(new int[]{1,2,3,4,5})).Returns(new int[]{5,4,3,2,1});
            }
        }

    }
}
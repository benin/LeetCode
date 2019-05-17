using NUnit.Framework;
using System.Collections;

namespace RemoveNthNodeFromEndOfList.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(SolutionTestCases), "TestCases")]
        public int[] SolutionTest(ListNode head, int n)
        {
            return new Solution().RemoveNthFromEnd(head, n).ToArray();
        }
    }

    public static class SolutionTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new ListNode(new int[] {1,2,3,4,5}), 2).Returns(new [] {1,2,3,5});
                yield return new TestCaseData(new ListNode(new int[] {1}), 1).Returns(new int[] {});
                yield return new TestCaseData(new ListNode(new int[] {1,2,3}), 1).Returns(new int[] {1,2});
                yield return new TestCaseData(new ListNode(new int[] {1,2,3}), 2).Returns(new int[] {1,3});
                yield return new TestCaseData(new ListNode(new int[] {1,2,3}), 3).Returns(new int[] {2,3});
            }
        }
    }
}
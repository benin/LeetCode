using NUnit.Framework;
using System.Collections;

namespace MergeTwoSortedLists.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(SolutionTestCases), "TestCases")]
        public int[] SolutionTest(ListNode l1, ListNode l2)
        {
            return new Solution().MergeTwoLists(l1, l2).ToArray();
        }
    }

    public static class SolutionTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new ListNode(new int[]{1,2,4}),
                    new ListNode(new int[]{1,3,4}))
                    .Returns(new int[] {1,1,2,3,4,4});

                yield return new TestCaseData(
                   new ListNode(new int[] {1}),
                   new ListNode(new int[] {2}))
                   .Returns(new int[] { 1, 2});

                yield return new TestCaseData(
                   new ListNode(new int[] { 2 }),
                   new ListNode(new int[] { 1 }))
                   .Returns(new int[] { 1, 2 });

                yield return new TestCaseData(
                   new ListNode(new int[] { -2, -1 }),
                   new ListNode(new int[] { -2, -1 }))
                   .Returns(new int[] { -2, -2, -1, -1 });

                yield return new TestCaseData(
                   new ListNode(new int[] {1,2,3}),
                   new ListNode(new int[] {4}))
                   .Returns(new int[] { 1,2,3,4 });

                yield return new TestCaseData(
                   new ListNode(new int[] {4,5}),
                   new ListNode(new int[] {1,2,3,7,8,9}))
                   .Returns(new int[] {1,2,3,4,5,7,8,9});

                yield return new TestCaseData(
                   new ListNode(new int[] {5}),
                   new ListNode(new int[] {10,11,23}))
                   .Returns(new int[] {5,10,11,23});
            }
        }
    }
}
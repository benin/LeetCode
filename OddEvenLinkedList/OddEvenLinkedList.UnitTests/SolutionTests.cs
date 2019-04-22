using NUnit.Framework;
using System.Collections;

namespace OddEvenLinkedList.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(SolutionTestCases), "TestCases")]
        public int[] SolutionTest(ListNode list)
        {
            new Solution().OddEvenList(list);
            return list.ToArray();
        }
    }

    public static class SolutionTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new ListNode(new[] { 1, 2, 3, 4, 5 }))
                    .Returns(new[] { 1, 3, 5, 2, 4 }).SetName("LeetCodeExample1");
                yield return new TestCaseData(new ListNode(new[] { 2, 1, 3, 5, 6, 4, 7 }))
                    .Returns(new[] { 2, 3, 6, 7, 1, 5, 4 }).SetName("LeetCodeExample2");
                yield return new TestCaseData(new ListNode(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }))
                    .Returns(new []{1,3,5,7,2,4,6,8}).SetName("LeetCodeTestCase2");
                yield return new TestCaseData(new ListNode(new[] { 1 }))
                    .Returns(new[] { 1 }).SetName("One item");
                yield return new TestCaseData(new ListNode(new[] { 1, 2 }))
                    .Returns(new[] { 1, 2 }).SetName("No change");
                yield return new TestCaseData(new ListNode(new[] { 1, 2, 3 }))
                    .Returns(new[] { 1, 3, 2 }).SetName("123");
            }
        }
    }
}
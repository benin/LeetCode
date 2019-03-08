using NUnit.Framework;
using System.Collections;
using PalindromeLinkedList;

namespace PalindromeLinkedList.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(PalindromeLinkedListTestCases), "TestCases")]
        public bool SolutionTest(int[] nums)
        {
            var head = new ListNode(nums);
            return new Solution().IsPalindrome(head);
        }
    }

    public class PalindromeLinkedListTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[]{1, 2}).Returns(false);
                yield return new TestCaseData(new int[]{1, 2, 2, 1}).Returns(true);
                yield return new TestCaseData(new int[]{1, 2, 3, 2, 1}).Returns(true);
                yield return new TestCaseData(new int[]{1, 2, 3, 2, 3, 2, 1}).Returns(true);
                yield return new TestCaseData(new int[]{1, 2, 2, 2, 3, 2, 1}).Returns(false);
            }
        }
    }
}
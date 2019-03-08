using NUnit.Framework;
using System.Collections;
using PalindromeLinkedList;

namespace PalindromeLinkedList.UnitTests
{
    public class ListNodeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(LinkedListTestCases), "TestCases")]
        public void LsitNodeTest(int[] nums)
        {
            var list = new ListNode(nums);
            for( int i = 0; i < nums.Length; ++i)
                Assert.AreEqual(nums[0], list.val);
        }
    }

    public class LinkedListTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[]{1,2});
                    yield return new TestCaseData(new int[]{1,2,2,1});
                yield return new TestCaseData(new int[]{1,2,3,4,5,6,7,8,9,10});
            }
        }
    }
}
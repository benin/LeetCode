using NUnit.Framework;
using AddTwoNumbers;
using System.Collections;

namespace AddTwoNumbers.UnitTests
{
    [TestFixture]
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(SolutionTestCaseData), "TestCases")]
        public ListNode SolutionTest(ListNode l1, ListNode l2)
        {
            return new Solution().AddTwoNumbers(l1, l2);
        }
    }

    public class SolutionTestCaseData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData( 
                    new ListNode(new [] {2, 4, 3}),
                    new ListNode(new [] {5, 6, 4}))
                    .Returns(new ListNode(new [] {7, 0, 8}))
                    .SetName("342 + 465");

                yield return new TestCaseData( 
                    new ListNode(new [] {0}),
                    new ListNode(new [] {5, 6, 4})
                    ).Returns(new ListNode(new [] {5, 6, 4}))
                    .SetName("0 + 564");

                yield return new TestCaseData(
                    new ListNode(new [] {0}),
                    new ListNode(new [] {0})
                    ).Returns(new ListNode(new [] {0}))
                    .SetName("0 + 0");

                yield return new TestCaseData( 
                    new ListNode(new [] {9, 9}),
                    new ListNode(new [] {9, 9})
                    ).Returns(new ListNode(new [] {8, 9, 1}))
                    .SetName("99 + 99");

                yield return new TestCaseData(
                    new ListNode(new[] { 5, 4, 3, 2, 1 }),
                    new ListNode(new[] { 1, 2, 3, 4, 5 })
                    ).Returns(new ListNode(new[] { 6, 6, 6, 6, 6 }))
                    .SetName("54321 + 12345");

                yield return new TestCaseData(
                        new ListNode(new[] { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 }),
                        new ListNode(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 })
                    ).Returns(new ListNode(new[] { 1, 1, 2, 2, 2, 2, 2, 2, 2, 2}))
                    .SetName("0987654321 + 1234567890");
            }
        }  

    }
}
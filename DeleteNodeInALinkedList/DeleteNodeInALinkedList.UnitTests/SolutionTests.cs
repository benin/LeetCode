using NUnit.Framework;
using System.Collections;

namespace DeleteNodeInALinkedList.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SolutionTest(ListNode list, )
        {
            Assert.Pass();
        }
    }

    public class SolutionTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new ListNode(new int[] {4, 5, 1, 9}));
            }
        }
    }
}
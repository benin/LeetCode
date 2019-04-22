using NUnit.Framework;
using System.Collections;

namespace ReverseInteger.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(SolutionTestCases), "TestCases")]
        public int SolutionTest(int x)
        {
            return new Solution().Reverse(x);
        }
    }

    public class SolutionTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(123).Returns(321);
                yield return new TestCaseData(-123).Returns(-321);
                yield return new TestCaseData(120).Returns(21);
                yield return new TestCaseData(1534236469).Returns(0);
                yield return new TestCaseData(1563847412).Returns(0);

                yield return new TestCaseData(0).Returns(0);
                yield return new TestCaseData(1).Returns(1);
                yield return new TestCaseData(99).Returns(99);
            }
        }
    }
}
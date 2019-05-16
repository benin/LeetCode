using NUnit.Framework;
using System.Collections;

namespace CountPrimes.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(SolutionLeetCodeTestCases), "TestCases")]
        public int SolutionLeetCodeTest(int n)
        {
            return new Solution().CountPrimes(n);
        }
    }

    public static class SolutionLeetCodeTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(0).Returns(0);
                yield return new TestCaseData(1).Returns(0);
                yield return new TestCaseData(2).Returns(0);
                yield return new TestCaseData(3).Returns(1);
                yield return new TestCaseData(10).Returns(4);
                yield return new TestCaseData(29).Returns(9);
                yield return new TestCaseData(30).Returns(10);
            }
        }
    }
    
}
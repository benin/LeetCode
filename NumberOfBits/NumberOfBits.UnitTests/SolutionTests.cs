using NUnit.Framework;
using System.Collections;
using NumberOfBits;

namespace NumberOfBits.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(ExampleTestCases), "TestCases")]
        public int SolutionTest(uint n)
        {
            return new Solution().HammingWeight(n);
        }
        
        [Test, TestCaseSource(typeof(ExampleTestCases), "TestCases")]
        public int SolutionIterateTest(uint n)
        {
            return new SolutionIterate().HammingWeight(n);
        }
    }

    public class ExampleTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData((uint)0b00000000000000000000000000000000).Returns(0);
                yield return new TestCaseData((uint)0b00000000000000000000000000000001).Returns(1);
                yield return new TestCaseData((uint)0b00000000000000000000000000001011).Returns(3);
                yield return new TestCaseData((uint)0b00000000000000000000000010000000).Returns(1);
                yield return new TestCaseData((uint)0b11111111111111111111111111111101).Returns(31);
            }
        }
    }
}
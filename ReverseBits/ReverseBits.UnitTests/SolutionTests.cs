using System.Collections;
using NUnit.Framework;

namespace ReverseBits.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(TestCasesData), "TestCases")]
        public uint SolutionTest(uint n) 
        {
            return new Solution().ReverseBits(n);
        }
    }

    public class TestCasesData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData((uint)0b00000010100101000001111010011100).Returns(0b00111001011110000010100101000000);
                yield return new TestCaseData((uint)0b11111111111111111111111111111101).Returns(0b10111111111111111111111111111111);
            }
        }
    }
}
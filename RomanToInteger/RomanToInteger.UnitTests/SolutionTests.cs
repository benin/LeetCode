using NUnit.Framework;
using System.Collections;

namespace RomanToInteger.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(SolutionTestCases), "TestCases")]
        public int SolutionTest(string s)
        {
            return new Solution().RomanToInt(s);
        }
    }

    public static class SolutionTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("III").Returns(3);
                yield return new TestCaseData("IV").Returns(4);
                yield return new TestCaseData("IX").Returns(9);
                yield return new TestCaseData("LVIII").Returns(58);
                yield return new TestCaseData("MCMXCIV").Returns(1994);
            }
        }
    }
}
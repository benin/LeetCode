using System.Collections;
using NUnit.Framework;
using CountAndSay;

namespace CountAndSay.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(TestCasesSource), "TestCases")]
        public string SolutionTest(int n) 
        {
            return new Solution().CountAndSay(n);
        }
    }

    public class TestCasesSource
    {
        public static IEnumerable TestCases
        {
            get 
            {
                yield return new TestCaseData(1).Returns("1");
                yield return new TestCaseData(2).Returns("11");
                yield return new TestCaseData(3).Returns("21");
                yield return new TestCaseData(4).Returns("1211");
                yield return new TestCaseData(5).Returns("111221");
                yield return new TestCaseData(6).Returns("312211");
                yield return new TestCaseData(7).Returns("13112221");
                yield return new TestCaseData(8).Returns("1113213211");
                yield return new TestCaseData(9).Returns("31131211131221");
                yield return new TestCaseData(10).Returns("13211311123113112211");
            }
        }
    }
}
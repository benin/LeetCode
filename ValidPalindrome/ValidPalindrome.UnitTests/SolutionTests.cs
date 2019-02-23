using NUnit.Framework;
using System.Collections;
using ValidPalindrome;

namespace ValidPalindrome.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(TestCases), "Tests")]
        public bool SolutionTest(string s)
        {
            return new Solution().IsPalindrome(s);
        }
    }

    public class TestCases
    {
        public static IEnumerable Tests
        {
            get 
            {
                yield return new TestCaseData("A man, a plan, a canal: Panama").Returns(true);
                yield return new TestCaseData("race a car").Returns(false);
                yield return new TestCaseData("aca").Returns(true);
                yield return new TestCaseData("OneNo").Returns(true);
                yield return new TestCaseData("OneEno").Returns(true);
                yield return new TestCaseData("0P").Returns(false);
            }
        }
    }
}
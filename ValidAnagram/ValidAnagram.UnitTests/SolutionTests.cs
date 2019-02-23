using NUnit.Framework;
using System.Collections;
using ValidAnagram;

namespace ValidAnagram.SolutionTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(ValidAnagramUnitTests), "Tests")]
        public bool SolutionTest(string s, string t) 
        {
            return new Solution().IsAnagram(s, t);
        }
    }

    public class ValidAnagramUnitTests
    {
        public static IEnumerable Tests
        {
            get
            {
                yield return new TestCaseData("anagram", "nagaram").Returns(true);
                yield return new TestCaseData("rat", "cat").Returns(false);
                yield return new TestCaseData("aabbccdd", "ddccaabb").Returns(true);
                yield return new TestCaseData("aaaaa", "aaaaa").Returns(true);
                yield return new TestCaseData("aaaab", "bbbba").Returns(false);
                yield return new TestCaseData("a", "").Returns(false);
                yield return new TestCaseData("", "a").Returns(false);
                yield return new TestCaseData("", "").Returns(true);
            }
        }
    }
}
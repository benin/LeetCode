using NUnit.Framework;
using FirstUniqueCharacter;
using System;
using System.Collections;

namespace FirstUniqueCharacter.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(LeetCodeExampleTestCases), "TestCases")]
        public int SolutionLeetCodeExamplesTests(string s)
        {
            return new Solution().FirstUniqChar(s);            
        }

        [Test, TestCaseSource(typeof(RangeTestCases), "TestCases")]
        public int SolutionRangeTests(string s)
        {
            return new Solution().FirstUniqChar(s);            
        }
    }

    public class LeetCodeExampleTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("leetcode").Returns(0);
                yield return new TestCaseData("loveleetcode").Returns(2);
            }
        }
    }
    
    public class RangeTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("a").Returns(0);
                yield return new TestCaseData("aab").Returns(2);
                yield return new TestCaseData("").Returns(-1);
                yield return new TestCaseData("aaaaaaaaaaa").Returns(-1);
                yield return new TestCaseData("aaaaaaaaaab").Returns(10);
                yield return new TestCaseData("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz").Returns(-1);
                yield return new TestCaseData("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxy").Returns(25);
            }
        }
    }

}
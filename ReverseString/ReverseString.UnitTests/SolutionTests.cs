using NUnit.Framework;
using System;
using System.Collections;
using ReverseString;

namespace ReverseString.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(LeetCodeExample), "TestCase")]
        public char[] LeetCodeTests(char[] s)
        {
            new Solution().ReverseString(s);
            return s;
        }

        [Test, TestCaseSource(typeof(RangeTests), "TestCase")]
        public char[] RangeTests(char[] s)
        {
            new Solution().ReverseString(s);
            return s;
        }
    }

    public class LeetCodeExample
    {
        public static IEnumerable TestCase
        {
            get
            {
                yield return new TestCaseData(new char[]{'h','e','l','l','o'}).Returns(new char[]{'o','l','l','e','h'});
                yield return new TestCaseData(new char[]{'H','a','n','n','a','h'}).Returns(new char[]{'h','a','n','n','a','H'});
            }
        }
    }    
    
    public class RangeTests
    {
        public static IEnumerable TestCase
        {
            get
            {
                yield return new TestCaseData(new char[]{}).Returns(new char[]{}).SetName("Empty.");
                yield return new TestCaseData(new char[]{'h'}).Returns(new char[]{'h'}).SetName("One letter.");
                yield return new TestCaseData(new char[]{'a','z'}).Returns(new char[]{'z','a'}).SetName("Two letters.");
            }
        }
    }    
}
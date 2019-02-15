using NUnit.Framework;
using System;
using System.Collections;
using PlusOne;

namespace PlusOne.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(TestCases), "MainTestCases")]
        public int[] SolutionMainTests(int[] digits)
        {
            return new Solution().PlusOne(digits);
        }

        [Test, TestCaseSource(typeof(TestCases), "LeetCodeTestCases")]
        public int[] SolutionLeetCodeTest(int[] digits)
        {
            return new Solution().PlusOne(digits);
        }
        
    }

    public class TestCases
    {
        public static IEnumerable LeetCodeTestCases
        {
            get
            {
                yield return new TestCaseData(new int[]{1,2,3}).Returns(new int[]{1,2,4}).SetName("123");
                yield return new TestCaseData(new int[]{4,3,2,1}).Returns(new int[]{4,3,2,2}).SetName("4321");
            }
        
        }
        public static IEnumerable MainTestCases
        {
            get
            {
                yield return new TestCaseData(new int[]{}).Returns(new int[]{1}).SetName("Empty");
                yield return new TestCaseData(new int[]{0}).Returns(new int[]{1}).SetName("0");
                yield return new TestCaseData(new int[]{9}).Returns(new int[]{1,0}).SetName("9");
                yield return new TestCaseData(new int[]{9,9,9}).Returns(new int[]{1,0,0,0}).SetName("999");
                
            }
        }
    }
}
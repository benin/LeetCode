using System;
using System.Collections;
using NUnit.Framework;
using SingleNumber;

namespace SingleNumber.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(LeetCodeTestCases), "TestCases")]
        public int SolutionTest(int[] nums)
        {
            return new Solution().SingleNumber(nums);
        }
    }

    public class LeetCodeTestCases
    {
        public static IEnumerable TestCases
        {
            get 
            {
                yield return new TestCaseData(new int[]{2,2,1}).Returns(1);
                yield return new TestCaseData(new int[]{4,1,2,1,2}).Returns(4);
                yield return new TestCaseData(new int[]{1,2,3,4,5,1,2,4,5}).Returns(3);
            }
        }
    }
}
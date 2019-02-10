using System;
using System.Collections;
using NUnit.Framework;
using Stock2;

namespace Stock2.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(LeetCodeTestCases), "TestCases")]
        public int MaxProfit(int[] prices)
        {
            return new Solution().MaxProfit(prices);
        }
    }

    public class LeetCodeTestCases
    {
        public static IEnumerable TestCases
        {
            get 
            {   
                yield return new TestCaseData(new [] {3,2,6,5,0,3}).Returns(7);
                yield return new TestCaseData(new [] {7,1,5,3,6,4}).Returns(7);
                yield return new TestCaseData(new [] {1,2,3,4,5}).Returns(4);
                yield return new TestCaseData(new [] {7,6,4,3,1}).Returns(0);
                yield return new TestCaseData(new [] {1,3,5,1,3,5}).Returns(8);
            }
        }
    }
}
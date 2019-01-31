using System;
using System.Collections;
using NUnit.Framework;
using RemoveDuplicates;
using FluentAssertions;

namespace Tests
{
    [TestFixture]
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(LeetCodeTestCases), "TestCases")]
        public int SolutionTest(int[] nums, int[] expected)
        {
            var solution = new Solution();
            var result = solution.RemoveDuplicates(nums);
            
            Array.Resize(ref nums, result);
            nums.Should().BeEquivalentTo(expected);

            return result;
        }
    }

    public class LeetCodeTestCases
    {
        public static IEnumerable TestCases
        {
            get 
            {
                yield return new TestCaseData(new [] {0,0,1,1,1,2,2,3,3,4}, new [] {0,1,2,3,4}).Returns(5);
                yield return new TestCaseData(new [] {1,1,2}, new [] {1,2}).Returns(2);
                yield return new TestCaseData(new [] {0}, new [] {0}).Returns(1);
                yield return new TestCaseData(new int[] {}, new int[] {}).Returns(0);
            }
        }
    }
}
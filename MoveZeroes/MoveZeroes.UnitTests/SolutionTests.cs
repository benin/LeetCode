using System;
using System.Collections;
using NUnit.Framework;
using MoveZeroes;

namespace MoveZeroes.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(BunchTestData), "TestData")]
        public int[] MoveZeroes(int[] nums)
        {
            new Solution().MoveZeroes(nums);
            return nums;
        }

        [Test, TestCaseSource(typeof(BunchTestData), "TestData")]
        public int[] MoveZeroesLinear(int[] nums)
        {
            new SolutionLinear().MoveZeroes(nums);
            return nums;
        }
    }

    public class BunchTestData
    {
        public static IEnumerable TestData
        {
            get 
            {
                yield return new TestCaseData(new int[] {4,2,4,0,0,3,0,5,1,0}).Returns(new int[]{4,2,4,3,5,1,0,0,0,0});
                yield return new TestCaseData(new int[] {0,1,0,3,12}).Returns(new int[]{1,3,12,0,0});
                yield return new TestCaseData(new int[] {0,0,0,0,1}).Returns(new int[]{1,0,0,0,0});
                yield return new TestCaseData(new int[] {0,0,0,0,0}).Returns(new int[]{0,0,0,0,0});
                yield return new TestCaseData(new int[] {1,2,3,4,5}).Returns(new int[]{1,2,3,4,5});
                yield return new TestCaseData(new int[] {1,0,0,0,1}).Returns(new int[]{1,1,0,0,0});
            }
        }
    }
}
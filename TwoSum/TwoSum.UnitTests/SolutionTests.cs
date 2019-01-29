using NUnit.Framework;
using System.Collections;

namespace TwoSum.UnitTests
{
    [TestFixture]
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(LeetCodeTestCases), "TestCases")]
        public int[] SolutionTest(int[] nums, int target)
        {
            return new Solution().TwoSum(nums, target);            
        }

        [Test, TestCaseSource(typeof(LeetCodeTestCases), "TestCases")]
        public int[] FastSolutionTest(int[] nums, int target)
        {
            return new FastSolution().TwoSum(nums, target);            
        }
    }

    public class LeetCodeTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData( new [] {2, 7, 11, 15}, 9).Returns(new[] {0, 1});
                yield return new TestCaseData( new [] {3, 2, 4}, 6).Returns(new[] {1, 2});
                yield return new TestCaseData( new [] {-1,-2,-3,-4,-5}, -8).Returns(new[] {2, 4});
                yield return new TestCaseData( new [] {3, 3}, 6).Returns(new[] {0, 1});
            }
        }  
    }
}
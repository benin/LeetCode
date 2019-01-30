using NUnit.Framework;
using System.Collections;
using TwoSum2;

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
        public int[] SolutionDictionaryTest(int[] nums, int target)
        {
            return new SolutionDictionary().TwoSum(nums, target);            
        }

        [Test, TestCaseSource(typeof(LeetCodeTestCases), "TestCases")]
        public int[] SolutionTest(int[] nums, int target)
        {
            return new Solution().TwoSum(nums, target);            
        }
    }

    public class LeetCodeTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData( new [] {2, 7, 11, 15}, 9).Returns(new[] {1, 2});
                yield return new TestCaseData( new [] {-1, 0}, -1).Returns(new[] {1, 2});
            }
        }  
    }
}
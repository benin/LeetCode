using NUnit.Framework;

namespace TwoSum.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase( new [] {2, 7, 11, 15}, 9, ExpectedResult=new[] {0, 1})]
        [TestCase( new [] {3, 2, 4}, 6, ExpectedResult=new[] {1, 2})]
        [TestCase( new [] {-1,-2,-3,-4,-5}, -8, ExpectedResult=new[] {2, 4})]
        public int[] ExampleTest(int[] nums, int target)
        {
            return new Solution().TwoSum(nums, target);            
        }
    }
}
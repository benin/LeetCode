using NUnit.Framework;

namespace TwoSum.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ExampleTest()
        {
            var nums = new [] {2, 7, 11, 15};
            int target = 9;
            
            var solution = new Solution();

            solution.TwoSum(nums, target);

            Assert.Pass();
        }
    }
}
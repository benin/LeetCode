using System.Collections;
using NUnit.Framework;
using ContainsDuplicate;

namespace ContainsDuplicate.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(LeetCodeExamples), "TestCases")]
        public bool BasicSolutionTest(int[] nums)
        {
            return new Solution().ContainsDuplicate(nums);
        }
    }

    public class LeetCodeExamples
    {
        public static IEnumerable TestCases
        {
            get 
            {
                yield return new TestCaseData(new int[] {1,2,3,1}).Returns(true).SetName("Example 1");
                yield return new TestCaseData(new int[] {1,2,3,4}).Returns(false).SetName("Example 2");
                yield return new TestCaseData(new int[] {1,1,1,3,3,4,3,2,4,2}).Returns(true).SetName("Example 3");
            }
        }
    }
}
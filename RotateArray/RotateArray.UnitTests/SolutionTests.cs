using NUnit.Framework;
using System.Collections;
using RotateArray;

namespace RotateArray.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(AllTestCases), "TestCases")]
        public int[] SolutionSingleShiftTest(int[] nums, int k)
        {
            new SolutionSingleShift().Rotate(nums, k);
            return nums;
        }
        
        [Test, TestCaseSource(typeof(AllTestCases), "TestCases")]
        public int[] SolutionNewArrayTest(int[] nums, int k)
        {
            new SolutionNewArray().Rotate(nums, k);
            return nums;
        }
    }

    public class AllTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[]{1,2,3,4,5,6,7}, 3).Returns(new int[]{5,6,7,1,2,3,4});
                yield return new TestCaseData(new int[]{-1,-100,3,99}, 2).Returns(new int[]{3,99,-1,-100});
                yield return new TestCaseData(new int[]{}, 5).Returns(new int[]{});
                yield return new TestCaseData(new int[]{1}, 7).Returns(new int[]{1});
                yield return new TestCaseData(new int[]{1,2}, 10).Returns(new int[]{1,2});
                yield return new TestCaseData(new int[]{1,2,3,4,5}, 4).Returns(new int[]{2,3,4,5,1});
            }
        }
    }
}
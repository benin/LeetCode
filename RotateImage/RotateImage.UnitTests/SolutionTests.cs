using NUnit.Framework;
using System.Collections;

namespace RotateImage.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(SolutionTestCases), "TestCases")]
        public int[][] SolutionTest(int[][] matrix)
        {
            new Solution().Rotate(matrix);
            return matrix;
        }
    }

    public class SolutionTestCases
    {
        public static IEnumerable TestCases
        {
            get 
            {
                yield return new TestCaseData(new []{
                new int[][] {
                new []{1,2,3},
                new []{4,5,6},
                new []{7,8,9}
                }})
                .Returns(new int[][] {
                new []{7,4,1},
                new []{8,5,2},
                new []{9,6,3}
                });

                yield return new TestCaseData(new []{
                new int[][] {
                new []{ 5, 1, 9, 11},
                new []{ 2, 4, 8, 10},
                new []{13, 3, 6, 7},
                new []{15, 14,12,16}
                }})
                .Returns(new int[][] {
                new []{15, 13,2, 5},
                new []{14, 3, 4, 1},
                new []{12, 6, 8, 9},
                new []{16, 7, 10,11}
                });

                yield return new TestCaseData(new []{
                new int[][] {
                new []{ 1,  2,  3,  4, 5},
                new []{ 6,  7,  8,  9, 10},
                new []{11, 12, 13, 14, 15},
                new []{16, 17, 18, 19, 20},
                new []{21, 22, 23, 24, 25}
                }})
                .Returns(new int[][] {
                new []{21, 16, 11,  6, 1},
                new []{22, 17, 12,  7, 2},
                new []{23, 18, 13,  8, 3},
                new []{24, 19, 14,  9, 4},
                new []{25, 20, 15, 10, 5}
                });
            }
        }
    }
}
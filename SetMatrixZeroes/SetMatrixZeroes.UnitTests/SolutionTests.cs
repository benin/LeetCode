using System.Collections;
using NUnit.Framework;
using SetMatrixZeroes;

namespace SetMatrixZeroes.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(SolutionTestCases), "TestCases")]
        public int[,] SolutionTest(int[,] matrix) 
        {
            new Solution().SetZeroes(matrix);
            return matrix;
        }
    }

    public class SolutionTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[,] 
                {   {1,1,1},
                    {1,0,1},
                    {1,1,1}
                }).Returns(new int[,] 
                {   {1,0,1},
                    {0,0,0},
                    {1,0,1}
                });
                yield return new TestCaseData(new int[,] 
                {   {0,1,2,0},
                    {3,4,5,2},
                    {1,3,1,5}
                }).Returns(new int[,] 
                {   {0,0,0,0},
                    {0,4,5,0},
                    {0,3,1,0}
                });
                yield return new TestCaseData(new int[,] 
                {   {2147483647},
                    {2},
                    {3}
                }).Returns(new int[,] 
                {   {2147483647},
                    {2},
                    {3}
                });

                yield return new TestCaseData(new int[,] 
                {   {-4,-2147483648,6,-7,0},
                    {-8,6,-8,-6,0},
                    {2147483647,2,-9,-6,-10}}
                ).Returns(new int[,] 
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {2147483647,2,-9,-6,0}
                });
            }
        }
    }
}
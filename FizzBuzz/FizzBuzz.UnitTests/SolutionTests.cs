using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace FizzBuzz.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(SolutionTestCases), "TestCases")]
        public IList<string> SolutionLeetCodeTest(int n)
        {
            return new Solution().FizzBuzz(n);
        }
    }

    public static class SolutionTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(15).Returns(new List<string>{
                    "1",
                    "2",
                    "Fizz",
                    "4",
                    "Buzz",
                    "Fizz",
                    "7",
                    "8",
                    "Fizz",
                    "Buzz",
                    "11",
                    "Fizz",
                    "13",
                    "14",
                    "FizzBuzz"
                });
            }
        }
    }
}
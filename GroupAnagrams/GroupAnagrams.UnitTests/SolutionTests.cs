using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace GroupAnagrams.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(SolitionTestsCases), "TestCases")]
        public IList<IList<string>> SolutionTest(string[] strs) 
        {
            return new Solution().GroupAnagrams(strs);
        }
    }

    public static class SolitionTestsCases
    {
        public static IEnumerable TestCases
        {
            get 
            {
                yield return new TestCaseData(new object[] { new string[] {"eat", "tea", "tan", "ate", "nat", "bat"}}).
                    Returns(new List<IList<string>>{
                        new List<string>{"ate","eat","tea"},
                        new List<string>{"nat","tan"},
                        new List<string>{"bat"}
                    });
            }
        }
    }
}
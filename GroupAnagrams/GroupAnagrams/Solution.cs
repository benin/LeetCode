using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams
{
    public class Solution
    {
        internal class Anagram
        {
            public string Src { get; }

            public readonly string Sorted;
        
            public Anagram(string src)
            {
                Src = src;
                var sortedChars = Src.ToCharArray();
                Array.Sort(sortedChars);
                Sorted = new string(sortedChars);
            }

            public override bool Equals(object obj)
            {
                if ((obj == null) || GetType() != obj.GetType()) 
                {
                    return false;
                }

                Anagram a = (Anagram) obj; 
                return Sorted.Equals(a.Sorted);
            }

            public override int GetHashCode()
            {
                return Sorted.GetHashCode();
            }
        }

        public IList<IList<string>> GroupAnagrams(string[] strs) 
        {
            var dict = new Dictionary<Anagram, IList<string>>();
            foreach(var str in strs)
            {
                var anagram = new Anagram(str);
                if (!dict.ContainsKey(anagram))
                {
                    dict[anagram] = new List<string>();
                }
                dict[anagram].Add(anagram.Src);
            }

            return dict.Values.ToList();
        }
    }
}

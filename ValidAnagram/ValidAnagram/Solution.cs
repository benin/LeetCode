using System;
using System.Collections;
using System.Collections.Generic;

namespace ValidAnagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t) 
        {
            var dict = new Dictionary<char, int>();

            foreach (var ch in s)
            {
                if(dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }else
                {
                    dict.Add(ch, 1);
                }
            }

            foreach (var ch in t)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch]--;
                    if(dict[ch] == 0)
                        dict.Remove(ch);
                } else
                    return false;
            }

            if (dict.Count > 0)
                return false;

            return true;
        }
    }
}

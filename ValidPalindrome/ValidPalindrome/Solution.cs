using System;

namespace ValidPalindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            var cleanStr = s.ToLowerInvariant();

            var clean = new char[cleanStr.Length];
            int length = 0;
            foreach(var ch in cleanStr)
            {
                if ((ch >= 'a' && ch <= 'z') ||
                    (ch >= '0' && ch <= '9'))
                {
                    clean[length++] = ch;
                }
            }

            int halfLength = length / 2;
            for (int i = 0; i < halfLength; ++i)
            {
                if (clean[i] != clean[length-i-1])
                    return false;
            }

            return true;
        }
    }
}

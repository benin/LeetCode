using System;

namespace ReverseString
{
    public class Solution
    {
        public void ReverseString(char[] s) 
        {
            if (s is null || s.Length == 0)
                return;

            int lengthMinus = s.Length - 1;
            int halfLength = s.Length / 2;
            for (int i = 0; i < halfLength; ++i)
            {
                var tpm = s[i];
                s[i] = s[lengthMinus - i];
                s[lengthMinus - i] = tpm;
            }
        }
    }
}

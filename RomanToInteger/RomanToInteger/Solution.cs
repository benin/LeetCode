using System;

namespace RomanToInteger
{
    public class Solution
    {
        public int RomanSymbolToInt(char c, char nextChar, out bool dbl)
        {
            dbl = false; 
            var uppChar = Char.ToUpper(c);
            var uppNextChar = Char.ToUpper(nextChar);

            if (uppNextChar != 0)
            {                
                if ((uppChar == 'I') && (nextChar == 'V')) 
                {
                    dbl = true;
                    return 4;
                }
                if ((uppChar == 'I') && (nextChar == 'X'))
                {
                    dbl = true;
                    return 9;
                }

                if ((uppChar == 'X') && (nextChar == 'L')) 
                {
                    dbl = true;
                    return 40;
                }
                if ((uppChar == 'X') && (nextChar == 'C'))
                {
                    dbl = true;
                    return 90;
                }
                
                if ((uppChar == 'C') && (nextChar == 'D'))
                {
                    dbl = true;
                    return 400;
                }
                if ((uppChar == 'C') && (nextChar == 'M'))
                {
                    dbl = true;
                    return 900;
                }
            }
            
            switch(uppChar)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: 
                    throw new ArgumentOutOfRangeException($"Could not convert symbol:'{c}'.");
            };
        }

        public int RomanToInt(string s) 
        {
            int res = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                char currChar = s[i];
                char nextChar = (i == s.Length - 1) ? (char)0 : s[i+1];

                res += RomanSymbolToInt(currChar, nextChar, out var dbl);
                if (dbl)
                    i++;
            }

            return res;
        }
    }
}

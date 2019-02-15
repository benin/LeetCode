using System;

namespace PlusOne
{
    public class Solution
    {
        public int[] PlusOne(int[] digits) 
        {
            int overflow = 1;
            for (int i = digits.Length -1; i >= 0 ; --i)
            {
                int val = digits[i] + overflow;
                if (val > 9)
                {
                    overflow = val - 9;
                    val -= 10;
                } else
                {
                    overflow = 0;
                }
                
                digits[i] = val;
            }

            if (overflow > 0)
            {
                var newRes = new int[digits.Length + 1];
                Array.Copy(digits, 0, newRes, 1, digits.Length);
                newRes[0] = overflow;
                return newRes;
            }

            return digits;
        }
    }
}

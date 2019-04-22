using System;

namespace ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            int res = 0;

            try
            {
                while (x != 0)
                {
                    int part = x % 10;
                    x /= 10;
                    checked
                    {
                        res *= 10;
                        res += part;
                    }
                }
            } catch (System.OverflowException e)
            {
                res = 0;
            }

            return res;
        }
    }
}

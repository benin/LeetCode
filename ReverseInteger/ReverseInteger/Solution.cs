using System;

namespace ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            long res = 0;
            while(x != 0)
            {
                int part = x % 10;
                x /= 10;
                res *= 10;
                res += part;
            }

            if (Math.Abs(res) > Int32.MaxValue)
                return 0;

            return (int)res;
        }
    }
}

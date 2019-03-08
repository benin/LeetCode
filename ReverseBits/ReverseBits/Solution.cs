using System;

namespace ReverseBits
{
    public class Solution
    {
        public uint ReverseBits(uint n) 
        {
            uint res = 0;
            for (int i = 31; i >= 0; --i)
            {
                if ((n & 1) == 1)
                {
                    res |= (uint)(1 << i);
                }
                n = n >> 1;
            }
            return res;
        }
    }
}

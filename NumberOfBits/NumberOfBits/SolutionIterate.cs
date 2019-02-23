using System;

namespace NumberOfBits
{

    public class SolutionIterate
    {
        public int HammingWeight(uint n)
        {
            int res = 0;
            while(n > 0)
            {
                if((n & 1) != 0)
                    res++;
                
                n >>= 1;
            }
            return res;
        }
    }

}
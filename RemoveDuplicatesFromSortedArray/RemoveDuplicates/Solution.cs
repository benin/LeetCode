using System;

namespace RemoveDuplicates
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums) 
        {
            if (nums.Length < 2)
                return nums.Length;

            int prev = nums[0];
            int uniqIndex = 0;
            int length = nums.Length;
            int val = prev;
            for (int i = 1; i < length; ++i)
            {
                val = nums[i];
                if (val != prev)
                {
                    nums[++uniqIndex] = val;
                    prev = val;
                }
            }

            return uniqIndex + 1;
        }
        
    }
}
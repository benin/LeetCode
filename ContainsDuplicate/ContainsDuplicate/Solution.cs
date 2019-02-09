using System;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums) 
        {
            int numsLength = nums.Length;
            var duplicates = new HashSet<int>(nums);

            return numsLength != duplicates.Count;
        }
    }
}

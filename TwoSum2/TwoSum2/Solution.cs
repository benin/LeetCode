using System;
using System.Collections.Generic;

namespace TwoSum2
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target) 
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var summ = nums[i] + nums[j];
                    if (summ == target)
                        return new int[] {i+1, j+1};
                    
                    if (summ > target)
                        break;
                }    
            }
            
            throw new ArgumentException("The solution has not been found.");
        }
    }
}

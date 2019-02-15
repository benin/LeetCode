using System;

namespace MoveZeroes
{
    public class SolutionLinear
    {
        public void MoveZeroes(int[] nums) 
        {
            int next = 0;
            int curr = 0;
            int top = nums.Length;
            
            while(curr < top && nums[next++] != 0) curr++;
            
            while(next < top)
            {
                if (nums[next] != 0)
                {
                    nums[curr++] = nums[next];
                    nums[next] = 0;
                }
                next++;
            }
        }
    }
}
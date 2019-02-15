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
            while(curr < top)
            {
                if (nums[curr] == 0)
                    while(nums[next] == 0 && next < top) next++;

                curr++;
            }
        }
    }
}
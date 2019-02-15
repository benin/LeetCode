using System;

namespace MoveZeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums) 
        {
            int top = nums.Length;
            for (int i = 0; i < top; ++i)
            {
                if (nums[i] == 0)
                {
                    int next = i;
                    while(i < top && nums[i] == 0) i++;
                    BubbleUp(nums, i, i-next,top--);
                    i = next;
                }
            }
        }

        private void BubbleUp(int[] nums, int pos, int gap, int top)
        {
            for (int i = pos; i < top; ++i)
            {                
                nums[i-gap] = nums[i];
                nums[i] = 0;
            }
        }
    }
}

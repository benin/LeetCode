using System;

namespace RotateArray
{
    public class SolutionSingleShift
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length < 2)
                return;

            int shift = k % nums.Length;
            if (shift == 0)
                return;

            while(--shift >= 0)
            {
                int next = nums[0];
                for (int i = 1; i < nums.Length; ++i)
                {
                    int tmp = nums[i];
                    nums[i] = next;
                    next = tmp;
                }
                nums[0] = next;
            }
        }
    }
}

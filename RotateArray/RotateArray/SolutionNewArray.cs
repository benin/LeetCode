using System;

namespace RotateArray
{
    public class SolutionNewArray
    {
        // Input: [1,2,3,4,5,6,7] and k = 3
        // Output: [5,6,7,1,2,3,4]
        public void Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length < 2)
                return;

            int shift = k % nums.Length;
            if (shift == 0)
                return;

            var res = new int[nums.Length];

            Array.Copy(nums, 0, res, shift, nums.Length-shift);
            Array.Copy(nums, nums.Length-shift, res, 0, shift);
            Array.Copy(res, nums, res.Length);
        }
    }
}

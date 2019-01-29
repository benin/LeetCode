using System;
using System.Collections.Generic;

namespace TwoSum
{
    public class FastSolution 
    {
        public int[] TwoSum(int[] nums, int target) 
        {
            // Build dictionary
            var dict = new Dictionary<int, IList<int>>(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                var value = nums[i];
                if (dict.ContainsKey(value))
                {
                    dict[value].Add(i);
                }
                else
                    dict.Add(value, new List<int>(){i});
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                var first = nums[i];
                
                if (dict.TryGetValue(target - first, out var second))
                {
                    if (second.Count > 1)
                        return new int[]{i, second[1]};
                    if (second[0] != i)
                        return new int[]{i, second[0]};
                }
            }
            
            throw new ArgumentException("The solution has not been found.");
        }
    }
}

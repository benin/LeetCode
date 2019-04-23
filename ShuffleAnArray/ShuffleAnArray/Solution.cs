using System;

namespace ShuffleAnArray
{
    public static class ArrayExtensions
    {
        public static void Swap(this int[] arr, int a, int b)
        {
            var tmp = arr[a];
            arr[a] = arr[b];
            arr[b] = tmp;
        }
    }

    public class Solution
    {
        private readonly int[] _nums;
        private readonly int[] _shuffled;
        private readonly int _n;

        private readonly Random _rnd;

        public Solution(int[] nums)
        {
            _nums = nums;
            _shuffled = new int[_nums.Length];
            _nums.CopyTo(_shuffled, 0);
            _n = _nums.Length;
            _rnd = new Random();
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            return _nums;
        }

        /** Returns a random shuffling of the array. */
        public int[] Shuffle()
        {
            for (int i = 0; i < _n; i++)
                _shuffled.Swap(i, _rnd.Next(i, _n));

            return _shuffled;
        }
    }
}

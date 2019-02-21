using System;
using System.Collections;
using System.Collections.Generic;

namespace ValidSudoku
{
    // Class that check whether set contains the digits 1-9 without repetition.
    public class SetValidator
    {
        private readonly HashSet<int> _set = new HashSet<int>();

        private readonly bool _isUnique;
        public bool IsUnique => _isUnique;
        
        public SetValidator(IEnumerable<int> nums)
        {
            _isUnique = true;
            foreach(var num in nums)
            {
                if (num != 0 && !_set.Add(num))
                {
                    _isUnique = false;
                    break;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace ValidSudoku
{
    // Class that check whether set contains the digits 1-9 without repetition.
    public class SetValidator
    {
        private readonly HashSet<int> _set = new HashSet<int>();
        
        public bool AddUnique(int val)
        {
            return _set.Add(val);
        }

        public void Reset()
        {
            _set.Clear();
        }
    }
}
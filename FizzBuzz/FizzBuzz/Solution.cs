using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Solution
    {
        public IList<string> FizzBuzz(int n) 
        {
            var resList = new List<string>(n);
            for (int i = 1; i <= n; i++)
            {
                var three = i % 3 == 0;
                var five = i % 5 == 0; 
                
                if (three && five)
                    resList.Add("FizzBuzz");
                else if (three)
                    resList.Add("Fizz");
                else if (five)
                    resList.Add("Buzz");
                else
                    resList.Add(i.ToString());
            }

            return resList;
        }
    }
}

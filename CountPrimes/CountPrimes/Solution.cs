using System;
using System.Collections.Generic;

namespace CountPrimes
{
    public class Solution
    {
        // Implementation of Sieve of Eratosthenes algorithm
        public int CountPrimes(int n) 
        {
            int res = 0;
            var sieve = new bool[n];

            int maxN = (int)Math.Sqrt(n);
            for (int i = 2; i <= maxN; ++i)
            {
                if (!sieve[i])
                {
                    for (var j = i*i; j < n; j+=i)
                    {
                        sieve[j] = true;
                    }
                }
            }

            for(int i = 2; i < n; ++i)
                if (!sieve[i])
                    res++;

            return res;
        }
    }
}

using System;

namespace Stock2
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int maxSumm = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                int summ = 0;
                summ += MaxSumm(i, prices.Length, prices);
                if (summ > maxSumm)
                    maxSumm = summ;    
            }

            return maxSumm;
        }

        private int MaxSumm (int start, int end, int[] prices)
        {
            int maxSumm = 0;
            for (int i = start + 1; i < end; i++)
            {
                int summ = prices[i] - prices[start];
                if (summ >= 0)
                {
                    summ += MaxSumm(i+1, end, prices);
                    if (summ >= maxSumm)
                        maxSumm = summ;
                }
            }
            return maxSumm;
        }

        // private int MaxSumm(int start, int end, int[] prices)
        // {
        //     int summ = 0;
        //     int i = start + 1;
            
        //     while (i < end && prices[i] - prices[start] <= 0)
        //         i++;

        //     if (i < end)
        //         summ += prices[i] - prices[start] + MaxSumm(++i, end, prices);

        //     return summ;
        // }

    }
}

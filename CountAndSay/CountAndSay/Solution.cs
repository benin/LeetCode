using System;
using System.Text;

namespace CountAndSay
{
    public class Solution
    {
        public string CountAndSay(int n) 
        {
            var builder = new StringBuilder();
            string res = "1";
            for (int i = 1; i < n; ++i)
            {
                builder.Clear();
                int pos = 0;
                char series = res[0];
                while(pos < res.Length)
                {
                    int count = 0;
                    while(pos < res.Length && series == res[pos])
                    {
                        count++;
                        pos++;
                    }
                    builder.Append(count.ToString());
                    builder.Append(series);
                    if (pos < res.Length)
                        series = res[pos];
                }
                res = builder.ToString();
            }
            
            return res;
        }
    }
}

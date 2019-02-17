using System;
using System.Collections;

namespace FirstUniqueCharacter
{
    public class Solution
    {
        public int FirstUniqChar(string s) 
        {
            // We are going to use the range [91; 122]
            const int mapStart = 91;
            const int mapEnd = 122;
            const int length = mapEnd-mapStart+1;
            
            var map = new int[length];
            for (int i = 0; i < length; i++)
                map[i] = -1;

            for (int i = 0; i < s.Length; i++)
            {
                int charData = (int)s[i]-mapStart;
                if (map[charData] == -1)
                    map[charData] = i;
                else if (map[charData] >=0 )
                    map[charData] = -2;
            }

            int min = s.Length;
            for (int i = 0; i < length; i++)
            {
                if (map[i] >=0 && map[i] < min)
                    min = map[i];
            }
            
            return min == s.Length ? -1 : min;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions._3._Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            if (n == 0) return 0;
            if (n == 1) return 1;

            int maxLength = 0;
            HashSet<char> charSet = new HashSet<char>();
            int left = 0;

            for (int right = 0; right < n; right++)
            {
                if (!charSet.Contains(s[right]))
                {
                    charSet.Add(s[right]);
                    maxLength = Math.Max(maxLength, right - left + 1);
                }
                else
                {
                    while (charSet.Contains(s[right]))
                    {
                        charSet.Remove(s[left]);
                        left++;
                    }
                    charSet.Add(s[right]);
                }
            }
            return maxLength;
        }
    }
}

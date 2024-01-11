using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions._1._Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, short> differences = new Dictionary<int, short>(128);
            for (short i = 0; i < nums.Length; i++)
            {
                if (differences.ContainsKey(nums[i]))
                {
                    return new int[2] { differences[nums[i]], i };
                    
                }
                differences[target - nums[i]] = i;
            }
            return new int[2];
        }
    }
}

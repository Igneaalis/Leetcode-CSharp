# 1. Two Sum

https://leetcode.com/problems/two-sum

```csharp
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
```
using System.Collections.Generic;

namespace LeetCode
{
    public class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);

                if (map.ContainsKey(target - nums[i]) && map[target- nums[i]] != i)
                    return new[] { map[target - nums[i]] ,i };

            }

            return new[] { 0, 0 };
        }
    }
}
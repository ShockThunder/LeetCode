using System;
using System.Linq;

namespace LeetCode.Arrays_101
{
    public class ThirdMax
    {
        public int Solution(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            if(nums.Length == 2)
                return nums[0] >= nums[1] ? nums[0] : nums[1];

            var firstMax = nums.Max();

            var numsList = nums.ToList();
            numsList.RemoveAll(x => x == firstMax);

            if (numsList.Count == 0)
                return firstMax;
            
            var secondMax = numsList.Max();
            numsList.RemoveAll(x => x == secondMax);

            if (numsList.Count == 0)
                return firstMax;
            

            return numsList.Max();
        }
    }
}


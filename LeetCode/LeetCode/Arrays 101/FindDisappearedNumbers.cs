using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Arrays_101
{
    public class FindDisappearedNumbers
    {
        public IList<int> Solution(int[] nums)
        {
            for (var i = 0; i < nums.Length; i ++) {
                var index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0) {
                    nums[index] = - nums[index];
                }        
            }
            
            var result = new List<int>();
            
            for (var i = 0; i < nums.Length; i ++) {
                if (nums[i] > 0) {
                    result.Add(i + 1);
                }
            }
            
            return result;
        }
    }
}
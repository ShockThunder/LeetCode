using System.Collections.Generic;

namespace LeetCode.Arrays_101
{
    public class SortArrayByParity
    {
        public int[] Solution(int[] nums)
        {
            var result = new int[nums.Length];
            var oddNums = new List<int>();
            var resultCounter = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result[resultCounter] = nums[i];
                    resultCounter++;
                }
                else
                {
                    oddNums.Add(nums[i]);
                }
            }

            for (var i = 0; i < oddNums.Count; i++)
            {
                result[resultCounter] = oddNums[i];
                resultCounter++;
            }

            return result;
        }
    }
}
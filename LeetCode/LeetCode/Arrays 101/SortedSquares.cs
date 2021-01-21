namespace LeetCode.Arrays_101
{
    using System;

    public class SortedSquares
    {
        public int[] Solution1(int[] nums)
        {
            var result = new int[nums.Length];
 
            for(var i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i] * nums[i];
            }
 
            Array.Sort(result);
            return result;
        }
        
        public int[] Solution2(int[] nums)
        {
            var result = new int[nums.Length];
 
            var left = 0;
            var right = nums.Length - 1;
            var i = right;
 
            while (left <= right)
            {
                var leftVal = nums[left] * nums[left];
                var rightVal = nums[right] * nums[right];
 
                if (leftVal > rightVal)
                {
                    result[i] = leftVal;
                    left++;
                }
                else
                {
                    result[i] = rightVal;
                    right--;
                }
                i--;
            }
 
            return result;
        }
    }
}
namespace LeetCode.Arrays_101
{
    public class FindMaxConsecutiveOnes
    {
        public int Solution(int[] nums)
        {
            var maxLen = 0;
            var len = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    len++;
             
                if (nums[i] == 0 || i == nums.Length - 1)
                {
                    if(maxLen < len)
                        maxLen = len;
             
                    len = 0;
                }
            }
         
            return maxLen;
        }
    }
}
namespace LeetCode
{
    public class BinarySearch
    {
        public int Solution(int[] nums, int target)
        {
            var startIndex = 0;
            var endIndex = nums.Length;
            var checkIndex = endIndex / 2;

            while (target != nums[checkIndex])
            {
                if (startIndex == checkIndex || endIndex == checkIndex)
                    return -1;
                
                if (nums[checkIndex] > target)
                {
                    endIndex = checkIndex;
                }
                else
                {
                    startIndex = checkIndex;
                }
                checkIndex = (endIndex - startIndex) / 2 + startIndex;

            }
            return checkIndex;
        }
    }
}
namespace LeetCode.Arrays_101
{
    public class MoveZeroes
    {
        public void Solution(int[] nums)
        {
            var lastZeroPointer = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0 && lastZeroPointer < i)
                {
                    var temp = nums[lastZeroPointer];
                    nums[lastZeroPointer++] = nums[i];
                    nums[i] = temp;
                }
                if(nums[lastZeroPointer] != 0){
                    lastZeroPointer++;
                }
            }
        }
    }
}
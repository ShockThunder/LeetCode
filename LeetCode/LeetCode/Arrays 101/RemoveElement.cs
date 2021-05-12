namespace LeetCode.Arrays_101
{
    public class RemoveElement
    {
        public int Solution(int[] nums, int val)
        {
            var length = 0;
            var swapped = 1;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    length++;
                }
                else
                {
                    if (i != nums.Length - 1 && i + swapped <= nums.Length)
                    {
                        var temp = nums[i];
                        nums[i] = nums[^swapped];
                        nums[^swapped] = temp;
                        swapped++;
                        i--;
                    }
                }
            }

            return length;
        }
    }
}
namespace LeetCode
{
    public class RotateArray
    {
        public void Solution(int[] nums, int k) 
        {
            if (nums.Length < 2)
                return;
            
            if(k == 0)
                return;

            while (k > nums.Length)
            {
                k -= nums.Length;
            }

            var rotatedTail = new int[k];
            
            //fill tail values
            for (var i = 0; i < k; i++)
            {
                rotatedTail[^(i + 1)] = nums[^(i + 1)];
            }

            for (var i = nums.Length - 1; i >= k; i--)
            {
                nums[i] = nums[i - k];
            }

            for (var i = 0; i < k; i++)
            {
                nums[i] = rotatedTail[i];
            }
        }
    }
}
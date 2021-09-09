namespace LeetCode
{
    public class TwoSumII
    {
        public int[] Solution(int[] numbers, int target)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                var t = target - numbers[i];
                var searchedIndex = BinarySearch(numbers, t);
                if (searchedIndex != -1 && searchedIndex != i)
                    return searchedIndex > i ? new[] { i + 1, searchedIndex + 1 } : new[] { searchedIndex + 1, i + 1 };
            }

            return null;
        }

        //Two pointer
        public int[] Solution2(int[] numbers, int target)
        {
            var i = 0;
            var j = numbers.Length - 1;
            
            while(i < j)
            {
                if (numbers[i] + numbers[j] == target)
                    return new[] { i + 1, j + 1 };

                if (numbers[i] + numbers[j] < target) i++;
                else j--;
            }

            return new[] { i + 1, j + 1 };
        }
            

        private int BinarySearch(int[] nums, int target)
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
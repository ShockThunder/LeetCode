namespace LeetCode.Arrays_101
{
    public class CheckIfNandItsDoubleExist
    {
        public bool Solution(int[] arr) {
            for (var i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && (arr[i] * 2 == arr[j] || arr[j] * 2 == arr[i]))
                        return true;
                }
            }

            return false;
        }
    }
}
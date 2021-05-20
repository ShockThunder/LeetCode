namespace LeetCode.Arrays_101
{
    public class ReplaceElements
    {
        public int[] Solution(int[] arr)
        {
            var maxValue = 0;
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                if (i == arr.Length - 1)
                {
                    maxValue = arr[i];
                    arr[i] = -1;
                }
                else
                {
                    if (arr[i] > maxValue)
                    {
                        var temp = maxValue;
                        maxValue = arr[i];
                        arr[i] = temp;
                    }
                    else
                    {
                        arr[i] = maxValue;
                    }
                }
            }

            return arr;
        }
    }
}
namespace LeetCode.Arrays_101
{
    public class DuplicateZeros
    {
        public int[] Solution1(int[] arr)
        {
            var resultPointer = 0;
            var result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (resultPointer >= arr.Length)
                    return result;
                
                if (arr[i] == 0)
                {
                    result[resultPointer] = 0;
                    if (resultPointer + 1 < arr.Length)
                    {
                        result[resultPointer + 1] = 0;
                        resultPointer++;
                    }
                }
                else
                {
                    result[resultPointer] = arr[i];
                }

                resultPointer++;
            }
            return result;
        }

        public int[] Solution2(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    if (i + 1 < arr.Length)
                    {
                        for (int j = arr.Length - 1; j > i; j--)
                        {
                            arr[j] = arr[j - 1];
                        }

                        arr[i + 1] = 0;
                        i++;
                    }
                }
            }

            return arr;
        }
    }
}
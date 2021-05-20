namespace LeetCode.Arrays_101
{
    public class ValidMountainArray
    {
        public bool Solution(int[] arr)
        {
            if (arr.Length < 3)
                return false;

            if (arr[1] < arr[0])
                return false;
            
            var asc = true;
            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                    return false;
                if (asc)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        asc = false;
                    }
                }
                else
                {
                    if (arr[i] > arr[i - 1])
                        return false;
                }
            }

            return !asc;
        }
    }
}
namespace LeetCode.Arrays_101
{
    using System;

    public class MergeSortedArray
    {
        public int[] Solution1(int[] nums1, int m, int[] nums2, int n)
        {
            var nums2Pointer = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                if (m + n == 1)
                    break;
                
                if (nums1[i] > nums2[nums2Pointer])
                {
                    for (var j = nums1.Length - 1; j > i; j--)
                    {
                        nums1[j] = nums1[j - 1];
                    }

                    nums1[i] = nums2[nums2Pointer];
                    nums2Pointer++;
                }

                if (n + m - 1 - i <= 1)
                {
                    nums1[i] = nums2[nums2Pointer];
                    nums2Pointer++;
                }
            }

            return nums1;
        }
        
        public int[] Solution2(int[] nums1, int m, int[] nums2, int n)
        {
            var nums1Position = nums1.Length - 1;
            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                nums1[nums1Position] = nums2[i];
                nums1Position--;
            }

            Array.Sort(nums1);

            return nums1;
        }
    }
}
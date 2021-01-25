namespace LeetCode.Arrays_101
{
    using System;

    public class MergeSortedArray
    {
        public int[] Solution1(int[] nums1, int m, int[] nums2, int n)
        {
            var i = m - 1;
            var j = n - 1;
            var k = m + n - 1;
            
            while(i >= 0 && j >= 0){
                if(nums1[i] >= nums2[j]){
                    nums1[k] = nums1[i];
                    i--;
                    k--;
                }
                else{
                    nums1[k] = nums2[j];
                    j--;
                    k--;
                }
            }
            
            while(j >= 0){
                nums1[k] = nums2[j];
                j--;
                k--;
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
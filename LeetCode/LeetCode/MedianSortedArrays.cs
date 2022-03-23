using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MedianSortedArrays
    {
        public double Solution(int[] nums1, int[] nums2)
        {
            double result = 0;

            var isEven = (nums1.Length + nums2.Length) % 2 == 0;
            var medianIndex = (nums1.Length + nums2.Length) / 2;
            var mergedArray = new int[nums1.Length + nums2.Length];

            var nums1Index = 0;
            var nums2Index = 0;
            for (int i = 0; i < mergedArray.Length; i++)
            {
                if(nums1Index < nums1.Length)
                {
                    if(nums2Index < nums2.Length)
                    {
                        if(nums1[nums1Index] < nums2[nums2Index])
                        {
                            mergedArray[i] = nums1[nums1Index];
                            nums1Index++;
                        }
                        else
                        {
                            mergedArray[i] = nums2[nums2Index];
                            nums2Index++;
                        }
                    }
                    else
                    {
                        mergedArray[i] = nums1[nums1Index];
                        nums1Index++;
                    }
                }
                else
                {
                    mergedArray[i] = nums2[nums2Index];
                    nums2Index++;
                }

                if(i == medianIndex)
                {
                    if (isEven)
                    {
                        result = ((double)mergedArray[medianIndex] + (double)mergedArray[medianIndex - 1]) / 2;
                        return result;
                    }
                    else
                    {
                        return mergedArray[medianIndex];
                    }
                }
            }

            return result;
        }
    }
}

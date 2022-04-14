using System;

namespace LeetCode
{
    public class ContainerWithMostWater
    {
        //Two pointers
        public int Solution(int[] height)
        {
            var result = 0;

            var leftIndex = 0;
            var rightIndex = height.Length - 1;

            while(leftIndex < rightIndex)
            {
                var area = Math.Min(height[leftIndex], height[rightIndex]) * (rightIndex - leftIndex);
                result = Math.Max(result, area);

                if (height[leftIndex] < height[rightIndex])
                    leftIndex++;
                else
                    rightIndex--;
            }

            return result;
        }
    }
}

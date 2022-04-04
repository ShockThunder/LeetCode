using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ContainerWithMostWater
    {
        public int Solution(int[] height)
        {
            var result = 0;

            for(var i = 0; i < height.Length; i++)
            {
                for(var j = i + 1; j < height.Length; j++)
                {
                    var lowPoint = height[i] < height[j] ? height[i] : height[j];
                    var area = lowPoint * (j - i);
                    if(area > result)
                        result = area;
                }
            }

            return result;
        }
    }
}

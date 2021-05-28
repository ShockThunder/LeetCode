using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Arrays_101
{
    public class HeightChecker
    {
        public int Solution(int[] heights)
        {
            var orderedHeights = new List<int>(heights);
            orderedHeights.Sort();

            return heights.Where((t, i) => t != orderedHeights[i]).Count();
        }
        
    }
}
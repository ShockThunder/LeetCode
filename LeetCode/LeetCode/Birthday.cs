using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Birthday
    {
        public int Solution(List<int> s, int d, int m)
        {
            var result = 0;
            var temp = 0;
            var counter = 0;
            for (var i = 0; i < s.Count; i++)
            {
                temp += s[i];
                counter++;
                if (temp == d && counter == m)
                {
                    result++;
                    i = i - counter + 1;
                    temp = 0;
                    counter = 0;
                }
                else if(temp > d || counter > m)
                {
                    i = i - counter + 1;
                    temp = 0;
                    counter = 0;
                }
            }
            return result;
        }
    }
}

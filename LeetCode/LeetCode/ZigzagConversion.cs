using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ZigzagConversion
    {
        public string Solution(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            if(numRows == 2)
            {
                var firstRow = string.Empty;
                var secondRow = string.Empty;

                for (int i = 0; i < s.Length; i++)
                {
                    if (i % 2 == 0 )
                        firstRow += s[i];
                    else
                        secondRow += s[i];
                }

                return firstRow + secondRow;
            }

            var result = string.Empty;
            var matrix = new char[numRows, s.Length];

            var curRow = 0;
            var curColumn = 0;
            var down = true;
            for(var i = 0; i < s.Length; i++)
            {
                matrix[curRow, curColumn] = s[i];
                
                if(curRow == numRows - 1)
                    down = false;
                else if (curRow == 0)
                    down = true;

                if(down)
                    curRow++;
                else
                {
                    curRow--;
                    curColumn++;
                }
            }

            for(var i = 0; i < numRows; i++)
            {
                for(var j = 0; j < s.Length; j++)
                {
                    if(matrix[i, j] != default)
                    {
                        result += matrix[i, j];
                    }
                }
            }

            return result;
        }
    }
}

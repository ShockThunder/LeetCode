using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class StringToInteger
    {
        public int Solution(string s)
        {
            s = s.Trim();
            var positive = true;
            var result = string.Empty;
            for(var i = 0; i < s.Length; i++)
            {
                if(i == 0)
                {
                    if (s[i] == '-')
                    {
                        positive = false;
                        continue;
                    }
                    else if (s[i] == '+')
                        continue;
                }

                if (Char.IsDigit(s[i]))
                {
                    result += s[i];
                }
                else
                {
                    break;
                }
            }

            if (result.Length == 0)
                return 0;

            var isParsed = Int32.TryParse(result, out var parsedNumber);

            if (isParsed)
            {
                if (positive)
                    return parsedNumber;
                else
                    return 0 - parsedNumber;
            }

            if (positive)
                return Int32.MaxValue;
            else
                return Int32.MinValue;
        }
    }
}

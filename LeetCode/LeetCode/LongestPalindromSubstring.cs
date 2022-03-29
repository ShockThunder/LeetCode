using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestPalindromSubstring
    {
        public string Solution(string s)
        {
            var result = "";

            if(s.Length == 0)
                return result;
            if (s.Length == 1)
                return s;

            for(var i = 0; i < s.Length; i++)
            {
                var oddRes = Expand(s, i, i);
                var evenRes = Expand(s, i, i + 1);

                var longest = oddRes.Length > evenRes.Length ? oddRes : evenRes;
                result = result.Length > longest.Length ? result : longest;
            }

            return result;
        }

        private string Expand(string s, int start, int end)
        {
            var palindrome = "";
            while (start >= 0 && end < s.Length && s[start] == s[end])
            {
                palindrome = s.Substring(start, end - start + 1);
                start--;
                end++;   
            }

            return palindrome;
        }
    }
}

using System.Collections.Generic;

namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int Solution(string s)
        {
            var chars = new Dictionary<char, int>();
            var maxSequence = 0;

            var str = s.ToCharArray();

            for (var i = 0; i < str.Length; i++)
            {
                if (!chars.ContainsKey(str[i]))
                {
                    chars.Add(str[i], i);
                }
                else
                {
                    if (chars.Count > maxSequence)
                        maxSequence = chars.Count;

                    i = chars[str[i]];
                    
                    chars.Clear();
                }
            }
            
            if (chars.Count > maxSequence)
                maxSequence = chars.Count;

            return maxSequence;
        }
    }
}
using System.Collections;

namespace LeetCode
{
    public class PermutationInString
    {
        public bool Solution(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;
            
            var s1Map = new int[26];
            
            foreach (var t in s1)
                s1Map[t - 'a']++;

            for (var i = 0; i <= s2.Length - s1.Length; i++)
            {
                var s2Map = new int[26];
                for (var j = 0; j < s1.Length; j++)
                {
                    s2Map[s2[i + j] - 'a']++;
                }
                
                if (Matches(s1Map, s2Map))
                    return true;
            }

            return false;
        }

        private bool Matches(int[] s1Map, int[] s2Map) 
        {
            for (var i = 0; i < 26; i++) {
                if (s1Map[i] != s2Map[i])
                    return false;
            }
            return true;
        }
    }
}
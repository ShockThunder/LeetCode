namespace LeetCode.Recursion
{
    public class ReverseString
    {
        public char[] Solution(char[] s)
        {
            var topBorder = s.Length - 1;
            for (var i = 0; i < topBorder; i++)
            {
                var temp = s[i];
                s[i] = s[topBorder];
                s[topBorder] = temp;

                topBorder--;
            }

            return s;
        }
    }
}
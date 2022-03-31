using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseInteger
    {
        public int Solution(int x)
        {
            var chars = x.ToString().ToCharArray();
            var positive = true;

            if (chars[0] == '-')
            {
                chars = chars.Skip(1).ToArray();
                positive = false;
            }

            var reversed = new string(chars.Reverse().ToArray());

            var b = 0;
            var parsed = Int32.TryParse(reversed, out b);
            if (parsed)
            {
                if (!positive)
                    return 0 - b;
            }

            return b;
        }
    }
}

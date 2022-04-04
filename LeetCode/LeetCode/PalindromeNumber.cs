using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PalindromeNumber
    {
        public bool Solution(int x)
        {
            if(x < 0)
                return false;

            var strNum = new string(x.ToString().ToCharArray().Reverse().ToArray());

            var parsed = Int32.TryParse(strNum, out var y);

            if(parsed)
                if(x == y)
                    return true;
            return false;
        }

        public bool Solution2(int x)
        {         
            if (x < 0 || (x % 10 == 0 && x != 0))        
                return false;

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}

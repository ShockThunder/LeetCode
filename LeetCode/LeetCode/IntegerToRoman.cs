using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IntegerToRoman
    {
        public string Solution(int num)
        {
            //1 - I
            //5 - V
            //10 - X
            //50 - L
            //100 - C
            //500 - D
            //1000 - M
            
            var result = string.Empty;
            var thousands = num / 1000;
            var hundreds = (num - thousands * 1000) / 100;
            var tens = (num - thousands * 1000 - hundreds * 100) / 10;
            var ones = num - thousands * 1000 - hundreds * 100 - tens * 10;

            result += ReplaceThousands(thousands);
            result += ReplaceHundreds(hundreds);
            result += ReplaceTens(tens);
            result += ReplaceOnes(ones);

            return result;
        }
        
        public string ReplaceThousands(int num)
        {
            var result = string.Empty;

            for (var i = 1; i <= num; i++)
                result += "M";

            return result;
        }

        public string ReplaceHundreds(int num)
        {
            var result = string.Empty;

            if (num == 9)
                return "CM";
            if (num == 4)
                return "CD";

            if(num >= 5)
            {
                result = "D";

                for(var i = 1; i <= num - 5; i++)
                {
                    result += "C";
                }

                return result;
            }
            else
            {
                for (var i = 1; i <= num; i++)
                    result += "C";

                return result;
            }
        }

        public string ReplaceTens(int num)
        {
            var result = string.Empty;

            if (num == 9)
                return "XC";
            if (num == 4)
                return "XL";

            if (num >= 5)
            {
                result = "L";

                for (var i = 1; i <= num - 5; i++)
                {
                    result += "X";
                }

                return result;
            }
            else
            {
                for (var i = 1; i <= num; i++)
                    result += "X";

                return result;
            }
        }

        public string ReplaceOnes(int num)
        {
            var result = string.Empty;

            if (num == 9)
                return "IX";
            if (num == 4)
                return "IV";

            if (num >= 5)
            {
                result = "V";

                for (var i = 1; i <= num - 5; i++)
                {
                    result += "I";
                }

                return result;
            }
            else
            {
                for (var i = 1; i <= num; i++)
                    result += "I";

                return result;
            }
        }
    }
}

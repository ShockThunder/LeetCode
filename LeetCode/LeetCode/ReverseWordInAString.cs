using System.Linq;

namespace LeetCode
{
    public class ReverseWordInAString
    {
        public string Solution(string s)
        {
            var words = s.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i].ToCharArray();

                for (var j = 0; j < word.Length / 2; j++)
                {
                    var temp = word[j];
                    word[j] = word[word.Length - 1 - j];
                    word[word.Length - 1 - j] = temp;
                }

                words[i] = new string(word);
            }

            var result = string.Empty;
            for (var i = 0; i < words.Length; i++)
            {
                result += words[i] + " ";
            }

            result = result.Trim();

            return result;
        }
    }
}
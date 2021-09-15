using LeetCode;

using NUnit.Framework;

namespace Tests
{
    public class MediumTests
    {
        [Test]
        public void RotateArrayTests()
        {
            var nums = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var k = 3;
            var solver = new RotateArray();
            solver.Solution(nums, k);
            Assert.AreEqual(nums, new []{5,6,7,1,2,3,4});
        }

        [TestCase("aab", ExpectedResult = 2)]
        [TestCase("abcabcbb", ExpectedResult = 3)]
        [TestCase("dvdf", ExpectedResult = 3)]
        public int LongestSubstringWithoutRepeatingCharacters(string s)
        {
            var solver = new LongestSubstringWithoutRepeatingCharacters();

            return solver.Solution(s);
        }

        [TestCase("ab","eidbaooo", ExpectedResult = true)]
        [TestCase("ab","eidboaoo", ExpectedResult = false)]

        public bool PermutationInString(string s1, string s2)
        {
            var solver = new PermutationInString();
            return solver.Solution(s1, s2);
        }
    }
}
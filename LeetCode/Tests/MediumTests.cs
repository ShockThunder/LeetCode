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

        [Test]
        public void AddTwoNumbers()
        {
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var expectedRes = new ListNode(7, new ListNode(0, new ListNode(8)));
            var solver = new AddTwoNumbers();
            var result = solver.Solution(l1, l2);

            Assert.AreEqual(expectedRes.val, result.val);
            Assert.AreEqual(expectedRes.next.val, result.next.val);
            Assert.AreEqual(expectedRes.next.next.val, result.next.next.val);
        }

        [Test]
        public void MedianSortedArrays()
        {
            var nums1 = new int[] { 1, 2 };
            var nums2 = new int[] { 3, 4 };
            var expectedRes = 2.5d;
            var solver = new MedianSortedArrays();
            var result = solver.Solution(nums1, nums2);

            Assert.AreEqual(expectedRes, result);
        }
    }
}
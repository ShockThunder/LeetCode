using LeetCode;

using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class EasyTests
    {
        [TestCase(new[]{-1,0,3,5,9,12}, 2, ExpectedResult = -1)]
        public int BinarySearchTests(int[] nums, int target)
        {
            var solver = new BinarySearch();
            return solver.Solution(nums, target);
        }
        
        [Test]
        public void MergeTwoSortedListsTests()
        {
            var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            var result = new ListNode(1,
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));
            var solver = new MergeTwoSortedLists();
            var res = solver.Solution(l1, l2);

            Assert.AreEqual(res, result);
        }

        [TestCase(new []{3,2,4}, 6, ExpectedResult = new [] {1,2})]
        [TestCase(new []{2,7,11,15}, 9, ExpectedResult = new [] {0,1})]
        public int[] TwoSumTests(int[] nums, int target)
        {
            var solver = new TwoSum();
            return solver.Solution(nums, target);
        }
    }
}
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
    }
}
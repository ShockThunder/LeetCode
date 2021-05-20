namespace Tests.DataStructures
{
    using LeetCode.Arrays_101;

    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {

        [TestCase(new int[]{1,1,1,0}, ExpectedResult = 3)]
        [TestCase(new int[]{0,0,0,0}, ExpectedResult = 0)]
        [TestCase(new int[]{1,0,0,0}, ExpectedResult = 1)]
        [TestCase(new int[]{0,1,0,0}, ExpectedResult = 1)]
        [TestCase(new int[]{0,0,1,0}, ExpectedResult = 1)]
        [TestCase(new int[]{1,1,0,1}, ExpectedResult = 2)]
        [TestCase(new int[]{1,0,1,0}, ExpectedResult = 1)]
        [TestCase(new int[]{0,1,1,0}, ExpectedResult = 2)]
        [TestCase(new int[]{0,1,1,0,1,1,1}, ExpectedResult =3)]

        public int MaxConsequenceTest(int[] data)
        {
            var testClass = new FindMaxConsecutiveOnes();
            var res = testClass.Solution(data);
            return res;
        }

        [TestCase(new int[]{1,0,2,3,0,4,5,0}, ExpectedResult = new int[]{1,0,0,2,3,0,0,4})]
        [TestCase(new int[]{1,0,2,0,0,4,5,0}, ExpectedResult = new int[]{1,0,0,2,0,0,0,0})]
        public int[] DuplicateZerosTestSolution1(int[] data)
        {
            var testClass = new DuplicateZeros();
            var res = testClass.Solution1(data);
            return res;
        }
        
        [TestCase(new int[]{1,0,2,3,0,4,5,0}, ExpectedResult = new int[]{1,0,0,2,3,0,0,4})]
        [TestCase(new int[]{1,0,2,0,0,4,5,0}, ExpectedResult = new int[]{1,0,0,2,0,0,0,0})]
        public int[] DuplicateZerosTestSolution2(int[] data)
        {
            var testClass = new DuplicateZeros();
            var res = testClass.Solution2(data);
            return res;
        }
        
        [Test]
        public void MergeSortedArraySolution1()
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var nums2 = new int[] { 2, 5, 6 };
            var n = 3;
            var expectedResult = new int[] { 1, 2, 2, 3, 5, 6 };
            var testClass = new MergeSortedArray();
            var res = testClass.Solution1(nums1, m, nums2, n);
            Assert.AreEqual(expectedResult, res);
        }
        
        [Test]
        public void MergeSortedArraySolution2()
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var nums2 = new int[] { 2, 5, 6 };
            var n = 3;
            var expectedResult = new int[] { 1, 2, 2, 3, 5, 6 };
            var testClass = new MergeSortedArray();
            var res = testClass.Solution2(nums1, m, nums2, n);
            Assert.AreEqual(expectedResult, res);
        }

        [Test]
        public void RemoveElementSolution()
        {
            var nums = new int[] {3,2,2,3 };
            var val = 3;
            var testClass = new RemoveElement();
            var res = testClass.Solution(nums, val);
            Assert.AreEqual(2, res);
        }


        [Test]
        public void RemoveDuplicatesSolution()
        {
            var nums = new int[] {0,0,1,1,1,2,2,3,3,4};

        var testClass = new RemoveDuplicates();
            var res = testClass.Solution(nums);
            Assert.AreEqual(5, res);
        }
        
        [TestCase(new int[]{3,1,7,11}, ExpectedResult = false)]
        [TestCase(new int[]{7,1,14,11}, ExpectedResult = true)]
        public bool CheckIfExistSolution(int[] data)
        {
            var testClass = new CheckIfNandItsDoubleExist();
            return testClass.Solution(data);
        }
        
        [TestCase(new int[]{2,1}, ExpectedResult = false)]
        [TestCase(new int[]{3,5,5}, ExpectedResult = false)]
        [TestCase(new int[]{0,3,2,1}, ExpectedResult = true)]
        public bool ValidMountainArraySolution(int[] data)
        {
            var testClass = new ValidMountainArray();
            return testClass.Solution(data);
        }
    }
}
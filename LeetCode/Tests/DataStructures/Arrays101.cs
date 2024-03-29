namespace Tests.DataStructures
{
    using LeetCode.Arrays_101;

    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [TestCase(new[] { 1, 1, 1, 0 }, ExpectedResult = 3)]
        [TestCase(new[] { 0, 0, 0, 0 }, ExpectedResult = 0)]
        [TestCase(new[] { 1, 0, 0, 0 }, ExpectedResult = 1)]
        [TestCase(new[] { 0, 1, 0, 0 }, ExpectedResult = 1)]
        [TestCase(new[] { 0, 0, 1, 0 }, ExpectedResult = 1)]
        [TestCase(new[] { 1, 1, 0, 1 }, ExpectedResult = 2)]
        [TestCase(new[] { 1, 0, 1, 0 }, ExpectedResult = 1)]
        [TestCase(new[] { 0, 1, 1, 0 }, ExpectedResult = 2)]
        [TestCase(new[] { 0, 1, 1, 0, 1, 1, 1 }, ExpectedResult = 3)]
        public int MaxConsequenceTest(int[] data)
        {
            var testClass = new FindMaxConsecutiveOnes();
            var res = testClass.Solution(data);
            return res;
        }

        [TestCase(new[] { 1, 0, 2, 3, 0, 4, 5, 0 }, ExpectedResult = new[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        [TestCase(new[] { 1, 0, 2, 0, 0, 4, 5, 0 }, ExpectedResult = new[] { 1, 0, 0, 2, 0, 0, 0, 0 })]
        public int[] DuplicateZerosTestSolution1(int[] data)
        {
            var testClass = new DuplicateZeros();
            var res = testClass.Solution1(data);
            return res;
        }

        [TestCase(new[] { 1, 0, 2, 3, 0, 4, 5, 0 }, ExpectedResult = new[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        [TestCase(new[] { 1, 0, 2, 0, 0, 4, 5, 0 }, ExpectedResult = new[] { 1, 0, 0, 2, 0, 0, 0, 0 })]
        public int[] DuplicateZerosTestSolution2(int[] data)
        {
            var testClass = new DuplicateZeros();
            var res = testClass.Solution2(data);
            return res;
        }

        [Test]
        public void MergeSortedArraySolution1()
        {
            var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var nums2 = new[] { 2, 5, 6 };
            var n = 3;
            var expectedResult = new[] { 1, 2, 2, 3, 5, 6 };
            var testClass = new MergeSortedArray();
            var res = testClass.Solution1(nums1, m, nums2, n);
            Assert.AreEqual(expectedResult, res);
        }

        [Test]
        public void MergeSortedArraySolution2()
        {
            var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var nums2 = new[] { 2, 5, 6 };
            var n = 3;
            var expectedResult = new[] { 1, 2, 2, 3, 5, 6 };
            var testClass = new MergeSortedArray();
            var res = testClass.Solution2(nums1, m, nums2, n);
            Assert.AreEqual(expectedResult, res);
        }

        [Test]
        public void RemoveElementSolution()
        {
            var nums = new[] { 3, 2, 2, 3 };
            var val = 3;
            var testClass = new RemoveElement();
            var res = testClass.Solution(nums, val);
            Assert.AreEqual(2, res);
        }


        [Test]
        public void RemoveDuplicatesSolution()
        {
            var nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            var testClass = new RemoveDuplicates();
            var res = testClass.Solution(nums);
            Assert.AreEqual(5, res);
        }

        [TestCase(new[] { 3, 1, 7, 11 }, ExpectedResult = false)]
        [TestCase(new[] { 7, 1, 14, 11 }, ExpectedResult = true)]
        public bool CheckIfExistSolution(int[] data)
        {
            var testClass = new CheckIfNandItsDoubleExist();
            return testClass.Solution(data);
        }

        [TestCase(new[] { 2, 1 }, ExpectedResult = false)]
        [TestCase(new[] { 3, 5, 5 }, ExpectedResult = false)]
        [TestCase(new[] { 0, 3, 2, 1 }, ExpectedResult = true)]
        public bool ValidMountainArraySolution(int[] data)
        {
            var testClass = new ValidMountainArray();
            return testClass.Solution(data);
        }

        [TestCase(new[] { 17, 18, 5, 4, 6, 1 }, ExpectedResult = new[] { 18, 6, 6, 6, 1, -1 })]
        [TestCase(new[] { 400 }, ExpectedResult = new[] { -1 })]
        public int[] ReplaceElementsSolution(int[] data)
        {
            var testClass = new ReplaceElements();
            return testClass.Solution(data);
        }

        [Test]
        public void MoveZeroesSolution()
        {
            var nums = new[] { 0, 1, 0, 3, 12 };
            var res = new[] { 1, 3, 12, 0, 0 };

            var testClass = new MoveZeroes();
            testClass.Solution(nums);
            Assert.AreEqual(nums, res);
        }

        [Test]
        public void SortArrayByParitySolution()
        {
            var nums = new[] { 3, 1, 2, 4 };
            var expected = new[] { 2, 4, 3, 1 };

            var testClass = new SortArrayByParity();
            var res = testClass.Solution(nums);
            Assert.AreEqual(expected, res);
        }
        
        [TestCase(new[] { 1,1,4,2,1,3 }, ExpectedResult = 3)]
        [TestCase(new[] { 5,1,2,3,4 }, ExpectedResult = 5)]
        [TestCase(new[] { 1,2,3,4,5 }, ExpectedResult = 0)]
        public int HeightCheckerSolution(int[] data)
        {
            var testClass = new HeightChecker();
            return testClass.Solution(data);
        }
        
        [TestCase(new[] { 3,2,1 }, ExpectedResult = 1)]
        [TestCase(new[] { 1,2 }, ExpectedResult = 2)]
        [TestCase(new[] { 2,2,3,1 }, ExpectedResult = 1)]
        public int ThirdMaxSolution(int[] data)
        {
            var testClass = new ThirdMax();
            return testClass.Solution(data);
        }
    }
}
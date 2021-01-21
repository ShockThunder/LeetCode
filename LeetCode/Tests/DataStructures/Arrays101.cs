namespace Tests.DataStructures
{
    using LeetCode.Arrays_101;

    using NUnit.Framework;

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

        public int[] DuplicateZerosTest(int[] data)
        {
            var testClass = new DuplicateZeros();
            var res = testClass.Solution(data);
            return res;
        }
    }
}
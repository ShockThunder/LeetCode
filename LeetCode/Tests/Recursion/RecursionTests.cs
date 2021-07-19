using LeetCode.Recursion;

using NUnit.Framework;

namespace Tests.Recursion
{
    [TestFixture]
    public class RecursionTests
    {
        [TestCase(new[] {'h','e','l','l','o' }, ExpectedResult = new[] {'o','l','l','e','h' })]
        [TestCase(new[] {'H','a','n','n','a','h' }, ExpectedResult = new[] {'h','a','n','n','a','H'})]
        public char[] ReverseString (char[] data)
        {
            var testClass = new ReverseString();
            var res = testClass.Solution(data);
            return res;
        }
    }
}
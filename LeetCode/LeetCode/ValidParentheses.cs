using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class ValidParentheses
    {
        public bool Solution(string s)
        {
            var stack = new Stack<char>();

            foreach (var t in s)
            {
                if(t == '(')
                    stack.Push(')');
                else if(t == '{')
                    stack.Push('}');
                else if(t == '[')
                    stack.Push(']');
                else if (stack.Count == 0 || stack.Pop() != t)
                    return false;
            }

            return stack.Count == 0;
        }
    }
}
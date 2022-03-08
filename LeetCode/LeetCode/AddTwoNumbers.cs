using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddTwoNumbers
    {
        public ListNode Solution(ListNode l1, ListNode l2)
        {
            var firstNumber = string.Empty;
            while(l1 != null)
            {
                firstNumber = l1.val.ToString() + firstNumber;
                l1 = l1.next;
            }

            var secondNumber = string.Empty;
            while (l2 != null)
            {
                secondNumber = l2.val.ToString() + secondNumber;
                l2 = l2.next;
            }

            var resultNumber = (int.Parse(firstNumber) + int.Parse(secondNumber)).ToString().ToCharArray();
            if(resultNumber.Length == 0)
            {
                return new ListNode(0);
            }

            var result = new ListNode();
            var nextNode = result;
            for (int i = resultNumber.Length - 1; i >= 0; i--)
            {
                nextNode.val = int.Parse(resultNumber[i].ToString());
                nextNode.next = new ListNode();
                nextNode = nextNode.next;
            }

            return result;
        }
    }
}

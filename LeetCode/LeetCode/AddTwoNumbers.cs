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

            ListNode result = null;
            var operatingNode = new ListNode();
            var nextRank = 0;
            while (l1 != null || l2 != null)
            {
                if(result == null)
                {
                    result = new ListNode();
                    operatingNode = result;
                }
                else
                {
                    operatingNode.next = new ListNode();
                    operatingNode = operatingNode.next;
                }
                var num1 = 0;
                var num2 = 0;

                if(l1 != null)
                {
                    num1 = l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    num2 = l2.val;
                    l2 = l2.next;
                }

                var sum = num1 + num2 + nextRank;
                if(sum >= 10)
                {
                    sum = sum - 10;
                    nextRank = 1;
                }
                else
                {
                    nextRank = 0;
                }

                operatingNode.val = sum;
            }
            if(nextRank == 1)
                operatingNode.next = new ListNode(1);

            return result;
        }
    }
}

namespace LeetCode
{
    public class MergeTwoSortedLists
    {
        public ListNode Solution(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            
            if (l2 == null)
                return l1;
            
            var result = new ListNode();

            if (l1.val > l2.val)
            {
                result.val = l2.val;
                l2 = l2.next;
            }
            else
            {
                result.val = l1.val;
                l1 = l1.next;
            }

            var lastResult = result;
            
            while (l1 != null || l2 != null)
            {
                var next = new ListNode();

                if (l1 != null && l2 != null)
                {
                    if (l1.val > l2.val)
                    {
                        next.val = l2.val;
                        l2 = l2.next;
                    }
                    else
                    {
                        next.val = l1.val;
                        l1 = l1.next;
                    }

                    lastResult.next = next;
                    lastResult = next;
                }
                else
                {
                    if (l1 == null)
                    {
                        next.val = l2.val;
                        l2 = l2.next;
                    }
                    else
                    {
                        next.val = l1.val;
                        l1 = l1.next;
                    }
                    
                    lastResult.next = next;
                    lastResult = next;
                }
                
            }

            return result;
        }
    }
}
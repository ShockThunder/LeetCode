namespace LeetCode
{
    public class RemoveNthFromEnd
    {
        public ListNode Solution(ListNode head, int n)
        {
            var left = head;
            var right = head;

            while(right != null) {
                right = right.next;
                if (n-- < 0) left = left.next; 
            } 

            if (n == 0) head = head.next;
            else left.next = left.next.next;

            return head;        
        }
    }
}
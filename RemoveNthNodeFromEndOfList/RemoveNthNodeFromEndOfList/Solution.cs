using System;

namespace RemoveNthNodeFromEndOfList
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var newHead = new ListNode(-1);
            newHead.next = head;

            var slow = newHead;
            var fast = head;

            while(--n > 0)
                fast = fast.next;
            
            while(fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            
            slow.next = slow.next.next;

            if(slow == newHead)
                return slow.next;

            return head;
        }
    }
}

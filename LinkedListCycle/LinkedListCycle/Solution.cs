using System;

namespace LinkedListCycle
{
    public class Solution
    {
        public bool HasCycle(ListNode head) 
        {
            if (head == null || head.next == null)
                return false;

            var fast = head;
            var slow = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    return true;
            }

            return false;
        }
    }
}

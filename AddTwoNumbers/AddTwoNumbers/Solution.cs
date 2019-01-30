using System;

namespace AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode node = result;

            int next = 0;
            while(l1 != null || l2 != null || next != 0)
            {
                var val = (l1?.val ?? 0) + (l2?.val ?? 0) + next;
                if (val >= 10)
                {
                    next = val / 10;
                    val -= 10;
                }
                else
                    next = 0;

                node = node.AddNext(val);

                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (result.next != null)
                result = result.next;

            return result;
        }
    }
}

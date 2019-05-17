using System;

namespace ReverseLinkedList
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head) 
        {
            var node = head;
            ListNode next = null;
            ListNode prev = null;
            while(node != null)
            {
                next = node.next;
                node.next = prev;
                prev = node;
                node = next;
            }

            return prev;
        }

        private ListNode ReverseListNode(ListNode node, ListNode prev)
        {
            if (node != null)
            {
                var next = node.next;
                node.next = prev;
                return ReverseListNode(next, node);
            }
            
            return prev;
        }

        public ListNode ReverseListRecursive(ListNode head) 
        {
            return ReverseListNode(head, null);
        }
    }
}

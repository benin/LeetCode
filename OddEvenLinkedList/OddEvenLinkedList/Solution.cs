using System;

namespace OddEvenLinkedList
{
    
    // Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) 
        { 
            val = x; 
        }

        public ListNode(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;

            val = nums[0];

            var node = this;
            for (int i = 1; i < nums.Length; i++)
            {
                node.next = new ListNode(nums[i]);
                node = node.next;
            }
        }

    }
    
    public class Solution
    {
        public ListNode OddEvenList(ListNode head) 
        {
            if (head?.next?.next == null)
                return head;

            var oddStartNode = head.next;
            
            var iter = head;
            while(iter.next?.next != null)
            {
                var nextOdd = iter.next;
                iter.next = iter.next.next;
                nextOdd.next = iter.next.next;
                iter = iter.next;
            }

            iter.next = oddStartNode;

            return head;
        }
    }
}

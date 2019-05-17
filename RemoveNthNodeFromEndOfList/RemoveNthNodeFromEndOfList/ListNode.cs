using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveNthNodeFromEndOfList
{
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
}

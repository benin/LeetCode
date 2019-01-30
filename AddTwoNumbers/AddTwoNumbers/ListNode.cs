using System;

namespace AddTwoNumbers
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

            ListNode node = this;
            for (int i = 1; i < nums.Length; i++)
                node = node.AddNext(nums[i]);
        }

        public override bool Equals(object obj) 
        {
            var listNode = obj as ListNode;

            if (listNode == null)
            {
                return false;
            }

            if (!val.Equals(listNode.val))
                return false;
             
            if (next == null && listNode.next == null)
                return true;

            if ((next == null && listNode.next != null) ||
                (next != null && listNode.next == null))
                return false;
                
            return next.Equals(listNode.next);
        }

        public override int GetHashCode() 
        {
            int hash = val;
            if (next != null)
                hash += next.GetHashCode();
            return hash;
        }
    }
}
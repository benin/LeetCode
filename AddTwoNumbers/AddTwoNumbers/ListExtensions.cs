using System;

namespace AddTwoNumbers
{
    public static class ListExtensions
    {
        public static ListNode AddNext(this ListNode l, int x) 
        {
            l.next = new ListNode(x);
            return l.next;
        }
    }
}
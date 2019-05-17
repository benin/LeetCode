using System;

namespace ReverseLinkedList
{
    public static class ListNodeExtension
    {
        public static int[] ToArray(this ListNode list)
        {
            if (list == null)
                return new int[0];

            int count = 1;
            ListNode iter = list;
            while(iter.next != null)
            {
                count++;
                iter = iter.next;
            }

            var arr = new int[count];
            iter = list;
            int i = 0;
            while(iter != null)
            {
                arr[i++] = iter.val;
                iter = iter.next;
            }

            return arr;
        }
    }
}
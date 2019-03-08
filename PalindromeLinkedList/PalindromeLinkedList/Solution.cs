using System;
using System.Collections;
using System.Collections.Generic;

namespace PalindromeLinkedList
{
    public class Solution
    {
        public bool IsPalindrome(ListNode head) 
        {
            var right = head;
            int length = 0;
            while(right != null)
            {
                right = right.next;
                length++;
            }
        
            int pos = 0;
            var arr = new int[length];
            right = head;
            while(right != null)
            {
                arr[pos++] = right.val;
                right = right.next;
            }

            int halfLength = length / 2;
            for (int i = 0; i < halfLength; ++i)
            {
                if (arr[i] != arr[length-i-1])
                    return false;
            }
            
            return true;
        }
    }
}

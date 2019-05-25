
namespace Structures
{
    public static class ListNodeExtension
    {
        public static int[] ToArray(this ListNode list)
        {
            int count = 1;
            ListNode iter = list;
            while (iter.next != null)
            {
                count++;
                iter = iter.next;
            }

            var arr = new int[count];
            iter = list;
            int i = 0;
            while (iter != null)
            {
                arr[i++] = iter.val;
                iter = iter.next;
            }

            return arr;
        }
    }
}
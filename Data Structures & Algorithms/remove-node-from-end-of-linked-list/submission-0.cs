/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
         if (head == null)
            return head;

            ListNode listNodeCounter = head;
            int Counter = 1;
            while (listNodeCounter != null && listNodeCounter.next != null)
            {
                Counter += 1;
                listNodeCounter = listNodeCounter?.next;
            }

            if(Counter == n)
            {
                return head?.next;
            }
            if(n > Counter)
            {
                return head;
            }
            int FirstpartCounter = Counter - n;
            ListNode slow = head;
            while (FirstpartCounter > 1)
            {
                slow = slow?.next;
                FirstpartCounter -= 1;
            }

            ListNode second = slow?.next;
            slow.next = slow.next?.next; // dividing
            second = second?.next; // second part skip the nth

            return head;
    }
}

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
    public void ReorderList(ListNode head) {
            if (head == null || head.next == null) return;

            ListNode slow = head;
            ListNode fast = head.next;

            // 1) Find the mid
            while (fast != null && fast.next != null)   // while, not if
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // 2) Divide by mid
            ListNode second = slow.next;   // capture BEFORE cutting
            slow.next = null;

            // 3) Reverse second half
            ListNode prev = null;
            while (second != null)
            {
                ListNode next = second.next;
                second.next = prev;
                prev = second;
                second = next;
            }

            // 4) Merge
            ListNode NewHead = head;
            while (head != null && prev != null)
            {
                ListNode firstNext = head.next;
                ListNode secondNext = prev.next;

                head.next = prev;
                prev.next = firstNext;

                head = firstNext;
                prev = secondNext;
            }
    }
}

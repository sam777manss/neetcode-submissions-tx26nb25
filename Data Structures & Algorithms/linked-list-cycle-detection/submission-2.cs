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
    public bool HasCycle(ListNode head) {
        if(head == null){
            return false;
        }
        if (head.next == null)
        {
            return false;
        }
        ListNode tortoise = head;
        ListNode hare = head;
        while (hare != null && tortoise != null)
        {
            tortoise = tortoise?.next;
            hare = hare?.next?.next;

            if (tortoise == hare)
                return true;
        }

        return false;
    }
}

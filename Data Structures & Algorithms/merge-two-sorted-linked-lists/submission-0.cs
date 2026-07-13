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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
 ListNode previous = null;
 ListNode current = null;
 while (list1 != null || list2 != null)
 {
     if (list1 == null)
     { current = list2; list2 = list2.next; }
     else if (list2 == null)
     { current = list1; list1 = list1.next; }
     else if (list1?.val > list2?.val)
     { current = list2; list2 = list2.next; }
     else
     { current = list1; list1 = list1?.next; }
         ListNode next = current.next;
         current.next = previous;
         previous = current;

     }
    current = previous;
    previous = null;
    while (current != null)
    {
        ListNode next = current.next;
        current.next = previous;
        previous = current;
        current = next;
    }
    return previous;
    }
}
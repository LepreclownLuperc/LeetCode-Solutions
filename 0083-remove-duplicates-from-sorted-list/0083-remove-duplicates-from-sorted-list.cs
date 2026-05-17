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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null || head.next == null) return head;

        if(head.val == head.next.val)
        {
            head.next = head.next.next;
            return DeleteDuplicates(head);
        }
        else
        {
            head.next = DeleteDuplicates(head.next);
            return head;
        }
    }
}
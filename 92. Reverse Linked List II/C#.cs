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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        var dummy = new ListNode(0,head);
        var leftTail = dummy;        
        var index = 1;

        for(; index < left; index++){
            leftTail = leftTail.next;
        }

        ListNode prev = null;
        var curr = leftTail.next;

        for(; index <= right; index++){
            var next = curr.next;
            (curr.next, prev) = (prev, curr);
            curr = next;
        }

        leftTail.next.next = curr;
        leftTail.next = prev;

        return dummy.next;
    }
}
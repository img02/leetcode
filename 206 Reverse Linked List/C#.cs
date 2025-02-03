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
    public ListNode ReverseList(ListNode head) {

        if (head == null || head.next == null) return head;
        //return Iterative(head);
        return Recursive(null, head);
    }

    private ListNode Iterative(ListNode head){
        ListNode prev = null;
        var curr = head;
		// store temp copy of the next node,
		// update current to |point| to previous
		// update previous to be the current node
		// update next to be curr, and repeat
        while (curr != null){
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
		// once curr is null, end of list reached,
		// return prev as head of new reversed list.
        return prev;
    }
	
	private ListNode Recursive(ListNode prev, ListNode curr){
		// if current node is null, end of list
        // return prev as head of newly reversed list
        if (curr == null) return prev;
		// temp store the next node
        var next = curr.next;
		// point curr node to prev
        curr.next = prev;
		// repeat with next set of nodes, curr as prev, next as curr.
        return Recursive(curr, next);
    }
}
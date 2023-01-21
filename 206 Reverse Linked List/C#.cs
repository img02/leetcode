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

        return reverseListIterative(head);
        //return reverseListRecursive(head, null);
    }

    private ListNode reverseListIterative(ListNode head)
    {
        ListNode prev = null;
        while (head != null)
        {
            var next = head.next;

            head.next = prev;
            prev = head;
            head = next;
        }
        return prev;
    }

    private ListNode reverseListRecursive(ListNode head, ListNode prev)
    {
        // if current node is null,
        // return prev as head of newly reversed list
        if (head == null) return prev;

        // store the next node
        var next = head.next;

        // assign current node's next node as previous node
        head.next = prev;
        // assign prev node to be current node
        prev = head;
        // assign current node to next node
        head = next;

        //repeat with new current / previous node
        return reverseListRecursive(head, prev);
    }
}
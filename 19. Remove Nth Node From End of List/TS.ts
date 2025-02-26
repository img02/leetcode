/**
 * Definition for singly-linked list.
 * class ListNode {
 *     val: number
 *     next: ListNode | null
 *     constructor(val?: number, next?: ListNode | null) {
 *         this.val = (val===undefined ? 0 : val)
 *         this.next = (next===undefined ? null : next)
 *     }
 * }
 */

function removeNthFromEnd(head: ListNode | null, n: number): ListNode | null {
    const dummy = new ListNode(0,head);
    let left = dummy;
    let right = head;

    while(n > 0){
        right = right.next;
        n--;
    }

    while(right != null){
        left = left.next;
        right = right.next;
    }

    left.next = left.next.next;

    return dummy.next;
};
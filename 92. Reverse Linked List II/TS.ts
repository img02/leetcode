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

function reverseBetween(head: ListNode | null, left: number, right: number): ListNode | null {

    let dummy: ListNode = new ListNode(0,head);
    let leftTail = dummy;
    let index = 1;

    for(; index < left; index++){
        leftTail = leftTail.next;
    }

    let curr = leftTail.next;
    let prev = null;

    for(; index <= right; index++){
        const next = curr.next;
        [curr.next, prev] = [prev, curr];
        curr = next;
    }

    leftTail.next.next = curr;
    leftTail.next = prev;

    return dummy.next;    
};
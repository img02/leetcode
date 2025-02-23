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

function reverseList(head: ListNode | null): ListNode | null {
    return iterative(head);
    //return recursive(head, null);
};

function iterative(head: ListNode | null): ListNode | null {
    if (head === null) return null; 

    let prev = null;
    let curr = head;

    while(curr != null){
        const next = curr.next;
        curr.next = prev;
        prev = curr;
        curr = next;        
    }
    // once curr is null, we break out of loop, and prev will be the new head
    return prev;
}

function recursive(head: ListNode | null, prev: ListNode | null): ListNode | null {
    if (head == null) return prev;
    const next = head.next;
    head.next = prev;
    return recursive(next, head);       
}
/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} left
 * @param {number} right
 * @return {ListNode}
 */
var reverseBetween = function(head, left, right) {
    if (left === right) return head;

    let dummy = {val: 0, next: head};

    let index = 1;
    let leftTail = dummy;
    let curr = head;
    // find the 'tail' of the left side list
    for (; index < left; index++){
        leftTail = curr;
        curr = curr.next;        
    }
    // reverse the list between left / right
    let prev = null;
    for(; index < right + 1; index++){
        const next = curr.next;
        curr.next = prev;
        prev = curr;
        curr = next;
    }
    // point the OG first node in the reversed section to the first node in the right side list
    leftTail.next.next = curr;
    // point the left side tail to the head of the reversed sublist (originally the tail of the sublist to be reversed)
    leftTail.next = prev;

    return dummy.next;
};
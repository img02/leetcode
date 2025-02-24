/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */

/**
 * @param {ListNode} head
 * @return {boolean}
 */
var hasCycle = function(head) {
    return withTwoPointers(head);
    //return withSet(head);
};

function withTwoPointers(head){
    let one = head;
    let two = head;

    while(two != null && two.next !== null ){
        one = one.next;
        two = two.next.next;
        if (one === two) return true;
    }

    return false;
}

function withSet(head){
    if (head === null) return false;
    
    const set = new Set();

    while(head.next != null){
        if(set.has(head)) return true;
        set.add(head);
        head = head.next;
    }
    return false;
}
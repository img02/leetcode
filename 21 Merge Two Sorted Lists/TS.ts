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

function mergeTwoLists(list1: ListNode | null, list2: ListNode | null): ListNode | null {
    //return recursive(list1, list2, new ListNode());
    return iterative(list1, list2);
};

function recursive(list1: ListNode | null, list2: ListNode | null, merged: ListNode) : ListNode {

    if (list1 != null && (list2 == null || list1.val <= list2.val)){
        merged.next = list1;
        recursive(list1.next, list2, merged.next);
    }
    else if (list2 != null){
        merged.next = list2;
        recursive(list1, list2.next, merged.next);
    }

    return merged.next;
}

function iterative(list1: ListNode | null, list2: ListNode | null) : ListNode | null {
    var merged = new ListNode();
    var curr = merged;

    while(list1 != null && list2 != null){
        if(list1.val <= list2.val){
            curr.next = list1;
            list1 = list1.next;
        }
        else {
            curr.next = list2;
            list2 = list2.next;
        }
        curr = curr.next;
    }

    if(list1 == null) curr.next = list2;
    else curr.next = list1;

    return merged.next;
}
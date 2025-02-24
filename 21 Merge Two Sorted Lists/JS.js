/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} list1
 * @param {ListNode} list2
 * @return {ListNode}
 */
var mergeTwoLists = function(list1, list2) {
    //return recursive(list1, list2, new ListNode());
    return iterative(list1, list2);
};

function recursive(list1, list2, merged){

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

function iterative(list1, list2){
    let merged = new ListNode();
    let head = merged;
    while(list1 != null && list2 != null){
        if (list1.val <= list2.val){
            merged.next = list1;
            list1 = list1.next;
        }
        else {
            merged.next = list2;
            list2 = list2.next;
        }
        merged = merged.next;
    }
    if (list1 == null) merged.next = list2;
    else merged.next = list1;
    return head.next;
}
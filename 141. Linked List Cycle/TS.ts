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

function hasCycle(head: ListNode | null): boolean {
    return withTwoPointers(head);
    //return withSet(head);
};

function withTwoPointers(head: ListNode | null): boolean{
    let one = head;
    let two = head;
    while(two != null && two.next != null){
        one = one.next;
        two = two.next.next;
        if(one === two) return true;
    }
    return false;
}

function withSet(head: ListNode | null): boolean {
    if (head === null) return false;
    const set = new Set<ListNode>();

    while(head.next != null){
        if(set.has(head)) return true;
        set.add(head);
        head = head.next;
    }

    return false;

}
/** 
 * Forward declaration of isBadVersion API.
 * @param   version   your guess about first bad version
 * @return 	 	      true if current version is bad 
 *			          false if current version is good
 * func isBadVersion(version int) bool;
 */

func firstBadVersion(n int) int {
    
    if n == 1 {
        return 1;
    }

    left, mid, right := 1, n/2, n

    for left <= mid && right > mid {
        if isBadVersion(mid) {
            // move left
            right = mid
            mid -= (mid-left+1)/2
        } else {
            // move right
            left = mid
            mid += (right-mid+1)/2
        }
    }

    return mid;
}
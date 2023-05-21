/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * func guess(num int) int;
 */

func guessNumber(n int) int {
    left, right := 1, n;

    for left < right {
        mid := left + (right -left)/2
		
        switch guess(mid){
            case 0: return mid //if found return immediately
            case -1: right = mid-1 // move left
            case 1: left = mid+1 // move right    
        }
    }

    // if the ans is never mid val, it will be left
    return left; 
}
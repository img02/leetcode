/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        var left = 1;
        var right = n;
        while (left < right)
        {
            var mid = left + (right-left)/2;
            switch (guess(mid)) 
            {
                case 0: return mid;
                case -1: // move window left
                    right = mid-1; 
                    break;
                case 1: // move window right
                    left = mid+1;
                    break;
            }
        }
        return left;
    }
}
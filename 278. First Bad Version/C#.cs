/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {

        if (n < 1) return 0;
        if (n == 1) return 1;

        n = n; 
        var mid = (n/2); //clamps to left
        var left = 0;
        var right = n;

        while (left <= mid && right > mid)
        {
            if (IsBadVersion(mid))
            {
                //go left
                right = mid;
                 //need to +1 else 0.5 will truncate to 0, resulting in no move when only 1 diff
                mid -= (1+mid-left)/2;
            }
            else 
            {   //go right
                left = mid;
                mid += (1+right-mid)/2;
            }
        }
        return mid; 
    }
}
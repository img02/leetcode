public class Solution {
    public int FindMin(int[] nums) {
        var lowest = nums[0];
        var left = 0;
        var right = nums.Length-1;
        

        while(left <= right){
            if(nums[left] < nums[right]) return Math.Min(nums[left], lowest);

            var mid = (right+left) / 2;

            lowest = Math.Min(nums[mid], lowest);
            // if mid number is greater than left, 
            // we are in og array section
            // check right side
            if(nums[mid] >= nums[left])
                left = mid+1;
            else
                right = mid-1;

        }
        return lowest;
        // default lowest number to first in array
        // if mid number is smaller than lowest, update
        //[4,5,6,7,0,1,2]
        // L     M     R
        // if num at M > L, then M is part of the left sorted portion
        // then L to M + 1, move m to new subarray 
        // ----
        //[5,6,0,1,2,3,4] //example with M < L
        // L M R        
        // if num at M < L
        // M is part of right sorted portion
        // so check left side

    }
}
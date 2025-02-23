public class Solution {
    public int Search(int[] nums, int target) {
        var left = 0;
        var right = nums.Length-1;

        while (left <= right){
            var mid = (right+left)/2;
            
            if(nums[mid] == target) return mid;

            // left side
            //if target between left and mid
            if (nums[left] <= nums[mid]){
                // if target greater than mid or less than left
                // go right side
                // could be wrapped around from rotation
                if (target > nums[mid] || target < nums[left])
                    left = mid + 1;
                else 
                   right = mid - 1;
            }
            //right side
            else {
                // if target less than mid, or greater than right - wrapped around to left side 
                if (target < nums[mid] || target > nums[right])
                    right = mid - 1;
                else 
                    left = mid + 1;
            }
        }

        return -1;        
    }
}
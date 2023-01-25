public class Solution {
    public int Search(int[] nums, int target) {
        var upper = nums.Length -1;
        var lower = 0;

        while (lower < upper)
        {
			// skewing mid index to the left
            var mid = (upper + lower) / 2;
            if (target > nums[mid])
            {
                lower = mid + 1;
            } 
            else {
                upper = mid;
            }            
        }
        return nums[upper] == target ? upper : -1;
    }
}
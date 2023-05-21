public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var left = 0;
        var right = nums.Length-1;
        while (left <= right)
        {
            var mid = left + (right-left)/2;
            var val = nums[mid];
            if (val > target) right = mid-1;
            else if (val < target) left = mid+1;          
            else return mid;
        }
        return left;       
    }
}
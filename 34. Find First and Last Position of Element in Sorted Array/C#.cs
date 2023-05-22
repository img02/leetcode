public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        var left = 0;
        var right = nums.Length-1;
        var res = new int[] {-1,-1};

        while (left <= right)
        {
            var mid = left + (right-left)/2;
            var val = nums[mid];
            if (nums[mid] == target)
            {
                res[0] = mid;
                res[1] = mid;
                break;
            }
            if (nums[mid] > target) 
                right = mid-1;
            else             
                left = mid+1;
        }

        while (res[0] > 0) 
        {
            var index = res[0]-1;
            if (index < 0 ||nums[index] != target)                
                break;            
            res[0] = index;
        }
        while (res[1] < nums.Length-1)
        { 
            var index = res[1]+1;
            if (index > nums.Length-1 || nums[index] != target)
                break;            
            res[1] = index;    
           
        }
        return res;
    }
}
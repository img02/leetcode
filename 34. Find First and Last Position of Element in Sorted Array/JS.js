/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var searchRange = function(nums, target) {
    let left = 0;
    let right = nums.length-1;
    let res = [-1,-1];

    while (left <= right)
    {
        const mid = Math.trunc(left + (right-left)/2);
        const val = nums[mid];
        if (val == target)
        {
            res[0] = mid;
            res[1] = mid;
            break;
        }
        if (val > target)        
            right = mid-1;         
        else         
            left = mid+1;
    }

    while (res[0] > 0)
    {
        const index = res[0]-1;
        if (index < 0 || nums[index] != target)
            break;
        res[0] = index;
    }
    while (res[1] < nums.length-1)
    {
        const index = res[1]+1;
        if (index > nums.length-1 || nums[index] != target)
            break;
        res[1] = index;
    }
    return res;
};
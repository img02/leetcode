/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function(nums, target) {
    let left = 0;
    let right = nums.length-1;
    while (left <= right)
    {
        const mid = Math.trunc(left + (right-left)/2);
        const val = nums[mid];
        if (val > target) right = mid-1;
        else if (val < target) left = mid+1;
        else return mid;
    }
    return left;
};
/**
 * @param {number[]} nums
 * @return {number}
 */
var findMin = function(nums) {
    if (nums.length == 1) return nums[0];

    let result = nums[0];
    let left = 0;
    let right = nums.length-1;

    while (left <= right){
        if(nums[left] < nums[right]) 
            return Math.min(result, nums[left]);

        const mid = Math.trunc((right + left) / 2);

        result = Math.min(nums[mid], result);
        // result first set to nums[0]
        // if current mid number is greater than left side
        // they are part of the same sorted portion
        // so check right side instead
        if (nums[mid] >= nums[left]){
            left = mid + 1;
        } else{
            right = mid - 1;
        }
    }
    
    return result;
};

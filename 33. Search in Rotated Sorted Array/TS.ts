afunction search(nums: number[], target: number): number {
    var left = 0;
    var right = nums.length-1;

    while (left <= right){
        const mid = Math.trunc((right+left)/2);

        if(nums[mid] === target) return mid;

        //if mid is part of left side
        // if left to mid section is in order
        // or same
        if (nums[mid] >= nums[left]){
            // if target greater than mid val
            // and less than left - might be wrapped
            // check right side
            if (target > nums[mid] || target < nums[left]){
                left = mid + 1;
            } 
            else {
                right = mid - 1;
            }
        }
        // if part of right side
        else {
            // if target doesnt' fall between mid and right
            if (target < nums[mid] || target > nums[right]){
                right = mid - 1;
            }
            else {
                left = mid + 1;
            }
        }
    }

    return -1;
};
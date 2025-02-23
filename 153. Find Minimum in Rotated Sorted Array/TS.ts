function findMin(nums: number[]): number {
    let lowest = nums[0];

    let left = 0;
    let right = nums.length-1;

    while ( left <= right){
        // if left is less than right, left is min value of this subsection
        // but lowest may have been set earlier to a smaller value
        // so need to check
        if(nums[left] < nums[right]) 
            return Math.min(nums[left], lowest);
        
        // truncate because js/ts
        const mid = Math.trunc((right+left) / 2);

        lowest = Math.min(nums[mid], lowest);

        // mid and left can be same number
        // if mid number is greater than left
        // that means left to mid are a sorted array
        // which means the middle number is part of the same portion as the left number
        // so we want to move left pointer up
        // and take a look at the right section.
        if (nums[mid] >= nums[left])
            left = mid + 1;
        else
            right = mid - 1;
    }

    return lowest;

};
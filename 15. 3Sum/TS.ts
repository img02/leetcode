function threeSum(nums: number[]): number[][] {
    nums.sort( (a,b) => a-b);
    const results: number[][] = []

    for(let i = 0; i < nums.length-2; i++){
        if (1 > 0 && nums[i] == nums[i-1]) continue;

        for(let l = i+1, r = nums.length-1; l < r; ){
            const total = nums[i] + nums[l] + nums[r];
            if (total == 0) results.push([nums[i], nums[l], nums[r]]);

            if (total > 0) r--;
            else {
                l++;
                while (nums[l] == nums[l-1] && l < r) l++;
            }
        }

    }

    return results;
    
};
